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
    interface IView
    {
        string ExcelPath { get; set; }
        string XCoordinateHeader { get; set; }
        string YCoordinateHeader { get; set; }
        string Projection { get; set; }
        BindingList<ColumnInfo> Zuordnungstable { get; set; }

        event EventHandler OnReadingExcel;
        event EventHandler OnStoreDb;
    }

    public class MockView : IView
    {
        public string ExcelPath { get => @"C:\Users\Lenovo G50-45\Desktop\hugedummy.xlsx"; set => throw new NotImplementedException(); }
        public string XCoordinateHeader { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string YCoordinateHeader { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Projection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public BindingList<ColumnInfo> Zuordnungstable { get; set; }

        public event EventHandler OnReadingExcel;
        public event EventHandler OnStoreDb;
    }
}
