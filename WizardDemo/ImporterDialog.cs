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
            ImportPage.AllowNext = false;
            InitEvents();


            //var view = new MockView();
            //var presenter = new Presenter.Presenter(view);
            var presenter = new Presenter.Presenter(this);

            //view.ReadExcel();
            //view.StoreDb();
        }

        private void InitEvents()
        {
            ImportPage.Commit += Import_Commit;
            MappingPage.Commit += (sender, e) => OnStoreDb(sender, e);
        }


        private void Import_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            OnReadingExcel(this, e);
        }

        public string ExcelPath { get => ExcelPathBox.Text; set => throw new NotImplementedException(); }
        public string XCoordinateHeader { get => XBox.SelectedValue.ToString(); set => throw new NotImplementedException(); }
        public string YCoordinateHeader { get => YBox.SelectedValue.ToString(); set => throw new NotImplementedException(); }
        public string Projection { get => ProjectionBox.SelectedValue.ToString(); set => throw new NotImplementedException(); }

        public object MappingDataSource => throw new NotImplementedException();
        public object XDataSource
        {
            get => throw new NotImplementedException(); set
            {
                XBox.DataSource = value;
                XBox.ValueMember = "Source";
                XBox.DisplayMember = "Destination";
            }
        }
        public object YDataSource
        {
            get => throw new NotImplementedException(); set
            {
                YBox.DataSource = value;
                YBox.ValueMember = "Source";
                YBox.DisplayMember = "Destination";
            }
        }
        public object ProjectionDataSource
        {
            get => throw new NotImplementedException(); set
            {
                ProjectionBox.DataSource = value;
                ProjectionBox.DisplayMember = "BoxText";
                ProjectionBox.ValueMember = "Proj4String";
            }
        }

        public event EventHandler OnReadingExcel;
        public event EventHandler OnStoreDb;
        public event EventHandler OnOpenZuordnungDialog;
        public event EventHandler<bool> GeometryStateChanged;

        private void ExcelPathButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog() { Filter = "Excel (*.xlsx) | *.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelPathBox.Text = dialog.FileName;
                    ImportPage.AllowNext = true;
                }
            }
        }

        private void CustomizeTableButton_Click(object sender, EventArgs e)
        {
            OnOpenZuordnungDialog(sender, e);
        }

        public void SetDefaultXHeader(CoordinatesViewModel item)
        {
            XBox.SelectedIndex = XBox.FindStringExact(item.Destination);
        }

        public void SetDefaultYHeader(CoordinatesViewModel item)
        {
            YBox.SelectedIndex = YBox.FindStringExact(item.Destination);
        }

        public void SwitchCoordinateEnabledState()
        {
            var state = !XBox.Enabled;

            XBox.Enabled = state;
            YBox.Enabled = state;
            ProjectionBox.Enabled = state;
            XLabel.Enabled = state;
            YLabel.Enabled = state;
            ProjectionLabel.Enabled = state;
        }

        private void CoordinateRadio_Click(object sender, EventArgs e)
        {
            CoordinateRadio.Checked = !CoordinateRadio.Checked;
            GeometryStateChanged(sender, CoordinateRadio.Checked);
        }
    }
}
