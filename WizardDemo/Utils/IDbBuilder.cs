using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Models;

namespace WizardDemo.Utils
{
    public interface IDbBuilder
    {
        string DbPath { get; }
        string TableName { get; }
        DataTable Data { get; }
        List<ColumnInfo> ColumnInfos { get; }

        void CreateTable();
        void InsertData();
    }

    public class DbBuilder : IDbBuilder
    {
        public DbBuilder(string dbPath, string tableName, DataTable data, List<ColumnInfo> columnInfos)
        {
            DbPath = dbPath;
            TableName = tableName;
            Data = data;
            ColumnInfos = columnInfos;
        }

        #region //ClassProperties
        public string DbPath { get; }
        public string TableName { get; }
        public DataTable Data { get; }
        public List<ColumnInfo> ColumnInfos { get; }
        #endregion

        public SQLiteConnection Connection
        {
            get
            {
                var connection = new SQLiteConnection($"Data Source={DbPath}");
                connection.Open();
                connection.EnableExtensions(true);
                return connection;
            }
        }

        public void CreateTable()
        {
            var createStatement = $"CREATE TABLE {TableName}";
            var headers = ColumnInfos
                .Select(info => $"{info.SourceName} {info.DataType.GetSqlDataType()}")
                .Aggregate((current, next) => $"{current}, {next}");

            var query = $"{createStatement} ({headers})";

            ExecuteQuery(query);
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
            var headerList = ColumnInfos
                .Select(info => info.SourceName);

            var headers = string.Join(",", headerList);
            var headerParameters = headerList
                .Select(value => $"@{value}")
                .Aggregate((current, next) => $"{current}, {next}");

            var query = $"INSERT INTO {TableName}({headers}) VALUES ({headerParameters})";

            for (int i = 0; i < Data.Rows.Count; i++)
            {
                using (var command = new SQLiteCommand())
                {
                    command.CommandText = query;

                    foreach (var info in ColumnInfos)
                    {
                        var cellValue = Data.Rows[i][info.SourceName].ToString();
                        var dynamicValue = info.DataType.GetDynamicValue(cellValue);

                        command.Parameters.AddWithValue($"@{info.SourceName}", dynamicValue);
                    }
                    ExecuteQuery(command);
                }
            }
        }
    }
}
