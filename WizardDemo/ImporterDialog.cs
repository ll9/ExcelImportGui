using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardDemo.Models;
using WizardDemo.View;

namespace WizardDemo
{
    public partial class ImporterDialog : Form, IView
    {

        public ImporterDialog()
        {
            InitializeComponent();
            Import.AllowNext = false;
            InitEvents();


            //var view = new MockView();
            //var presenter = new Presenter.Presenter(view);
            var presenter = new Presenter.Presenter(this);

            //view.ReadExcel();
            //view.StoreDb();
        }

        private void InitEvents()
        {
            Import.Commit += Import_Commit;
        }

        private void Import_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            OnReadingExcel(this, e);
        }

        public string ExcelPath { get => ExcelPathBox.Text; set => throw new NotImplementedException(); }
        public string XCoordinateHeader { get => XBox.Text; set => throw new NotImplementedException(); }
        public string YCoordinateHeader { get => YBox.Text; set => throw new NotImplementedException(); }
        public string Projection { get =>ProjectionBox.Text; set => throw new NotImplementedException(); }

        public object MappingDataSource => throw new NotImplementedException();
        public object XDataSource { get => throw new NotImplementedException(); set => XBox.DataSource = value; }
        public object YDataSource { get => throw new NotImplementedException(); set => YBox.DataSource = value; }
        public object ProjectionDataSource { get => throw new NotImplementedException(); set => ProjectionBox.DataSource = value; }

        public event EventHandler OnReadingExcel;
        public event EventHandler OnStoreDb;


        private void ExcelPathButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog() { Filter = "Excel (*.xlsx) | *.xlsx"})
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelPathBox.Text = dialog.FileName;
                    Import.AllowNext = true;
                }
            }
        }
    }
}
