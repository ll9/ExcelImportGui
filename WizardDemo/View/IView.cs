using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Models;

namespace WizardDemo.View
{
    interface IView
    {
        string ExcelPath { get; set; }
        string XCoordinateHeader { get; set; }
        string YCoordinateHeader { get; set; }
        string Projection { get; set; }
        List<ColumnInfo> Zuordnungstable { get; set; }

        event EventHandler OnReadingExcel;
        event EventHandler OnStoreDb;
    }
}
