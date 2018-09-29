using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Models;

namespace WizardDemo.Utils
{
    public interface IExcelReader
    {
        string Path { get; set; }

        DataTable ReadExcel();
        List<ColumnInfo> GetColumnInfos();
    }

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
