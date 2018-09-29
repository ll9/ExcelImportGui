using System;
using System.Collections.Generic;
using System.Data;
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

        public string DbPath { get; }
        public string TableName { get; }
        public DataTable Data { get; }
        public List<ColumnInfo> ColumnInfos { get; }

        public void CreateTable()
        {
            var query = $"CREATE TABLE {TableName}";

            throw new NotImplementedException();
        }

        public void InsertData()
        {
            throw new NotImplementedException();
        }
    }
}
