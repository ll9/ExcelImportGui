using System;
using System.ComponentModel;
using WizardDemo.Models;

namespace WizardDemo.View
{
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
