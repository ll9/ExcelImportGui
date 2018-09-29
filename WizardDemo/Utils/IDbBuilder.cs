using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Models;

namespace WizardDemo.Utils
{
    interface IDbBuilder
    {
        string DbPath { get; }
        string TableName { get; }
        DataTable Data { get; }
        List<ColumnInfo> ColumnInfos { get; }

        void CreateTable();
        void InsertData();
    }
}
