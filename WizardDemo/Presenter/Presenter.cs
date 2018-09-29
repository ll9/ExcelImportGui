using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.View;

namespace WizardDemo.Presenter
{
    class Presenter
    {
        public DataTable ExcelTable { get; set; }

        public Presenter(IView view)
        {
            View = view;

            InitEvent();
        }

        private void InitEvent()
        {
            View.OnReadingExcel += View_OnReadingExcel;
            View.OnStoreTable += View_OnStoreTable;
        }

        private void View_OnStoreTable(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_OnReadingExcel(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public IView View { get; }


    }
}
