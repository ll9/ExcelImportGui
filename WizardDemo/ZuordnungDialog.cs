using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardDemo.View;

namespace WizardDemo
{
    public partial class ZuordnungDialog : Form, IZuordnungView
    {
        public ZuordnungDialog()
        {
            InitializeComponent();
        }

        public object ZuordnungDataSource
        {
            get => throw new NotImplementedException(); set
            {
                columnInfoDataGridView.DataSource = value;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
