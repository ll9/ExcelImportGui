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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            var view = new MockView();
            var presenter = new Presenter.Presenter(view);

            view.ReadExcel();
            view.StoreDb();
        }
    }
}
