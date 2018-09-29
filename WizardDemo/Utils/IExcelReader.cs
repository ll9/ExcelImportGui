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
        string Path { get; }

        DataTable ReadExcel();
        List<ColumnInfo> GetColumnInfos();
    }
}
