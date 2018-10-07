using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Models;

namespace WizardDemo.Utils
{
    public interface IDbBuilder
    {
        string DbPath { get; }
        string TableName { get; }
        DataTable DataTable { get; }
        List<ColumnInfo> ColumnInfos { get; }

        void CreateTable();
        void InsertData();
    }
}
