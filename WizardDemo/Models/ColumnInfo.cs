using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardDemo.Models
{

    public class ColumnInfo
    {
        public ColumnInfo(string sourceName, string destinationName, DataType dataType)
        {
            SourceName = sourceName;
            DestinationName = destinationName;
            DataType = dataType;
        }

        public string SourceName { get; set; }
        public string DestinationName { get; set; }
        public DataType DataType { get; set; }
    }
}
