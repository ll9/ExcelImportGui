using System.Collections.Generic;
using System.Data;
using WizardDemo.Models;

namespace WizardDemo.Utils
{
    public class MockExcelReader : IExcelReader
    {
        public MockExcelReader(string path)
        {
            Path = path;
        }

        public string Path { get; set; }

        public List<ColumnInfo> GetColumnInfos()
        {
            return new List<ColumnInfo>();
        }

        public DataTable ReadExcel()
        {
            return new DataTable();
        }
    }
}
