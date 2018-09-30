using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WizardDemo.Models
{
    public class CoordinatesViewModel
    {
        public CoordinatesViewModel(string source, string destination)
        {
            Source = source;
            Destination = destination;
        }

        public string Source { get; set; }
        private string _destination;
        public string Destination
        {
            get => _destination;
            set
            {
                _destination = Regex.Replace(value, "[^0-9a-zA-Z]+", "");
            }
        }
    }
}
