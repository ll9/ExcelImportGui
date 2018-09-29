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
        private IExcelReader _reader;
        public IExcelReader ExcelReader
        {
            get
            {
                if (View.ExcelPath == null || !File.Exists(View.ExcelPath))
                {
                    throw new FileNotFoundException("Could not find Path to Excel File");
                }

                return (_reader == null || _reader.Path != View.ExcelPath) ? new MockExcelReader(View.ExcelPath) : _reader;
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
        }

        private void View_OnStoreDb(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_OnReadingExcel(object sender, EventArgs e)
        {
            ExcelTable = ExcelReader.ReadExcel();
            View.Zuordnungstable = new BindingList<ColumnInfo>(ExcelReader.GetColumnInfos());
        }

        public IView View { get; }


    }
}
