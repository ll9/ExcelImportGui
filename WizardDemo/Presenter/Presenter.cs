using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Models;
using WizardDemo.Utils;
using WizardDemo.View;

namespace WizardDemo.Presenter
{
    public class Presenter
    {
        public DataTable ExcelTable { get; set; }
        public List<ColumnInfo> ColumnInfos { get; set; }
        private IExcelReader _reader;
        public IExcelReader ExcelReader
        {
            get
            {
                if (View.ExcelPath == null || !File.Exists(View.ExcelPath))
                {
                    throw new FileNotFoundException("Could not find Path to Excel File");
                }

                return (_reader == null || _reader.Path != View.ExcelPath) ? new SimpleExcelReader(View.ExcelPath) : _reader;
            }
        }

        public Presenter(IView view)
        {
            View = view;

            InitEvent();
        }

        private void InitEvent()
        {
            View.OnReadingExcel += View_OnReadingExcel;
            View.OnStoreDb += View_OnStoreDb;
            View.OnOpenZuordnungDialog += View_OnOpenZuordnungDialog;
        }

        private void View_OnOpenZuordnungDialog(object sender, EventArgs e)
        {
            var dialog = new ZuordnungDialog();
            dialog.ZuordnungDataSource = ColumnInfos;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                View.XDataSource = GetPossibleCoordinates();
                View.YDataSource = GetPossibleCoordinates();
            }
        }

        private void View_OnStoreDb(object sender, EventArgs e)
        {
            const string DbPath = @"C:\Users\Lenovo G50-45\Desktop\exceltestfiles\temp.sqlite";

            if (File.Exists(DbPath))
            {
                File.Delete(DbPath);
            }


            var dbBuilder = new DbBuilder(
                DbPath,
                "LDS_FEATURES",
                ExcelTable,
                ColumnInfos,
                View.XCoordinateHeader,
                View.YCoordinateHeader,
                View.Projection
                );

            dbBuilder.CreateTable();
            dbBuilder.InsertData();
        }

        private void View_OnReadingExcel(object sender, EventArgs e)
        {
            ExcelTable = ExcelReader.ReadExcel();
            ColumnInfos = ExcelReader.GetColumnInfos();


            View.XDataSource = GetPossibleCoordinates();
            View.YDataSource = GetPossibleCoordinates();
            View.ProjectionDataSource = new[]
            {
                new ProjectionViewModel("ESPG:25832", "+proj=utm +zone=32 +ellps=GRS80 +units=m +no_defs "),
                new ProjectionViewModel("ESPG:25833", "+proj=utm +zone=33 +ellps=GRS80 +units=m +no_defs "),
                new ProjectionViewModel("ESPG:25834", "+proj=utm +zone=34 +ellps=GRS80 +units=m +no_defs "),
            };
        }

        private List<CoordinatesViewModel> GetPossibleCoordinates()
        {
            return ColumnInfos
                .Where(info => DataType.Numeric.HasFlag(info.DataType))
                .Select(info => new CoordinatesViewModel(info.SourceName, info.DestinationName))
                .ToList();
        }

        public IView View { get; }
    }
}
