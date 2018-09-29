using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using WizardDemo.Models;

namespace WizardDemo.Utils
{
    public class DbBuilder : IDbBuilder
    {
        private const string GeometryColumn = "geometry";

        public DbBuilder(string dbPath, string tableName, DataTable data, List<ColumnInfo> columnInfos, string xCoordinateHeader, string yCoordinateHeader, string projection)
        {
            DbPath = dbPath;
            TableName = tableName;
            Data = data;
            ColumnInfos = columnInfos;
            XCoordinateHeader = xCoordinateHeader;
            YCoordinateHeader = yCoordinateHeader;
            Projection = projection;
        }

        #region //ClassProperties
        public string DbPath { get; }
        public string TableName { get; }
        public DataTable Data { get; }
        public List<ColumnInfo> ColumnInfos { get; }
        public string XCoordinateHeader { get; }
        public string YCoordinateHeader { get; }
        public string Projection { get; }
        #endregion

        public SQLiteConnection Connection
        {
            get
            {
                var connection = new SQLiteConnection($"Data Source={DbPath}");
                connection.Open();
                connection.EnableExtensions(true);
                connection.LoadExtension("mod_spatialite");
                return connection;
            }
        }

        public void CreateTable()
        {
            var createStatement = $"CREATE TABLE {TableName}";
            var headers = GetColumInfoWithoutCoordinates()
                .Select(info => $"{info.DestinationName} {info.DataType.GetSqlDataType()}")
                .Aggregate((current, next) => $"{current}, {next}");

            var query = $"{createStatement} ({headers})";

            ExecuteQuery(query);
            AddGeometry();
        }

        private void AddGeometry()
        {
            // Init Spatial Metadata
            ExecuteQuery("SELECT InitSpatialMetaData(1)");
            ExecuteQuery($"SELECT AddGeometryColumn('{TableName}', '{GeometryColumn}', 4326, 'POINT', 'XY')");
        }

        private IEnumerable<ColumnInfo> GetColumInfoWithoutCoordinates()
        {
            return ColumnInfos
                            .Where(info => info.SourceName != XCoordinateHeader && info.SourceName != YCoordinateHeader);
        }

        private void ExecuteQuery(string query)
        {
            using (var command = new SQLiteCommand(query))
            {
                ExecuteQuery(command);
            }
        }

        private void ExecuteQuery(SQLiteCommand command)
        {
            using (var connection = Connection)
            {
                command.Connection = Connection;
                command.ExecuteNonQuery();
            }
        }

        public void InsertData()
        {
            var headerList = GetColumInfoWithoutCoordinates()
                .Select(info => info.DestinationName);

            var headers = headerList
                .Concat(new[] { GeometryColumn })
                .Aggregate((current, next) => $"{current}, {next}");

            var headerParameters = headerList
                .Select(value => $"@{value}")
                .Aggregate((current, next) => $"{current}, {next}");


            for (int i = 0; i < Data.Rows.Count; i++)
            {
                var x = double.Parse(Data.Rows[i][XCoordinateHeader].ToString());
                var y = double.Parse(Data.Rows[i][YCoordinateHeader].ToString());
                var geomText = GeometryTransformer.GetGeomFromTextString(x, y, Projection);
                var query = $"INSERT INTO {TableName}({headers}) VALUES ({headerParameters}, {geomText})";


                using (var command = new SQLiteCommand())
                {
                    command.CommandText = query;

                    foreach (var info in ColumnInfos)
                    {
                        var cellValue = Data.Rows[i][info.SourceName].ToString();
                        var dynamicValue = info.DataType.GetDynamicValue(cellValue);

                        command.Parameters.AddWithValue($"@{info.DestinationName}", dynamicValue);
                    }
                    ExecuteQuery(command);
                }
            }
        }
    }
}
