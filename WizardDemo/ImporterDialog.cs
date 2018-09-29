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

            var view = new MockView();
            var presenter = new Presenter.Presenter(view);

            view.ReadExcel();
            view.StoreDb();
        }

        public string ExcelPath { get => ExcelPathBox.Text; set => throw new NotImplementedException(); }
        public string XCoordinateHeader { get => XBox.Text; set => throw new NotImplementedException(); }
        public string YCoordinateHeader { get => YBox.Text; set => throw new NotImplementedException(); }
        public string Projection { get =>ProjectionBox.Text; set => throw new NotImplementedException(); }
        public BindingList<ColumnInfo> Zuordnungstable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler OnReadingExcel;
        public event EventHandler OnStoreDb;
    }
}
