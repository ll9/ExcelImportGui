using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Models;

namespace WizardDemo.View
{
    public interface IView
    {
        string ExcelPath { get; set; }
        string XCoordinateHeader { get; set; }
        string YCoordinateHeader { get; set; }
        string Projection { get; set; }
        object MappingDataSource { get; }
        object XDataSource { get; set; }
        object YDataSource { get; set; }
        object ProjectionDataSource { get; set; }

        event EventHandler OnReadingExcel;
        event EventHandler OnStoreDb;
        event EventHandler OnOpenZuordnungDialog;
        event EventHandler<bool> GeometryStateChanged;

        void SetDefaultXHeader(CoordinatesViewModel item);
        void SetDefaultYHeader(CoordinatesViewModel item);
        void SwitchCoordinateEnabledState();
    }
}
