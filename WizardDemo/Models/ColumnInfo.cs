using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WizardDemo.Models
{

    public class ColumnInfo
    {
        public ColumnInfo(string sourceName, DataType dataType)
        {
            SourceName = sourceName;
            DestinationName = sourceName;
            DataType = dataType;
            Keep = true;
        }

        public string SourceName { get; set; }
        private string _destinationName;
        public string DestinationName
        {
            get => _destinationName;
            set
            {
                _destinationName = Regex.Replace(value, "[^0-9a-zA-Z]+", "");
            }
        }
        public DataType DataType { get; set; }
        public bool Keep { get; set; }
    }
}
