using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Models;

namespace WizardDemo.Utils
{
    interface IExcelReader
    {
        string Path { get; set; }

        DataTable ReadExcel();
        List<ColumnInfo> GetColumnInfos();
    }
}
