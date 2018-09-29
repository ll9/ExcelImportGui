using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardDemo.Models
{
    class ProjectionViewModel
    {
        public ProjectionViewModel(string boxText, string proj4String)
        {
            BoxText = boxText;
            Proj4String = proj4String;
        }

        public string BoxText { get; set; }
        public string Proj4String { get; set; }
    }
}
