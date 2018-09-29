using System;
using System.ComponentModel;
using WizardDemo.Models;

namespace WizardDemo.View
{
    public class MockView : IView
    {
        public string ExcelPath { get => @"C:\Users\Lenovo G50-45\Desktop\exceltestfiles\normalCoordinates.xlsx"; set => throw new NotImplementedException(); }
        public string XCoordinateHeader { get => "RW"; set => throw new NotImplementedException(); }
        public string YCoordinateHeader { get => "HW"; set => throw new NotImplementedException(); }
        public string Projection { get => "+proj=utm +zone=32 +ellps=GRS80 +units=m +no_defs "; set => throw new NotImplementedException(); }
        public BindingList<ColumnInfo> Zuordnungstable { get; set; }

        public object MappingDataSource => throw new NotImplementedException();

        public object XDataSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object YDataSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object ProjectionDataSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler OnReadingExcel;
        public event EventHandler OnStoreDb;

        public void ReadExcel()
        {
            OnReadingExcel(this, null);
        }
        public void StoreDb()
        {
            OnStoreDb(this, null);
        }
    }
}
