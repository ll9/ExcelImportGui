using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardDemo.View
{
    interface IView
    {
        string ExcelPath { get; set; }
        string XCoordinateHeader { get; set; }
        string YCoordinateHeader { get; set; }
        string Projection { get; set; }
        DataTable Zuordnungstable { get; set; }

        event EventHandler OnReadingExcel;
        event EventHandler OnStoreTable;
    }
}
