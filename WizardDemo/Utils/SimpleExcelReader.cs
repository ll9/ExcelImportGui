using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WizardDemo.Models;

namespace WizardDemo.Utils
{
    public class SimpleExcelReader : IExcelReader
    {
        public SimpleExcelReader(string path)
        {
            Path = path;
        }

        public string Path { get; }



        public List<ColumnInfo> GetColumnInfos()
        {
            var columnInfos = new List<ColumnInfo>();

            DataTable table = ReadExcel();
            foreach (DataColumn column in table.Columns)
            {
                var columnItems = table
                    .AsEnumerable()
                    .Select(row => row[column].ToString())
                    .ToList();

                var type = TypeGuesser.GuessType(columnItems);
                columnInfos.Add(new ColumnInfo(column.ColumnName, type));
            }
            return columnInfos;
        }

        public DataTable ReadExcel()
        {
            // Open the Excel file using ClosedXML.
            // Keep in mind the Excel file cannot be open when trying to read it
            using (XLWorkbook workBook = new XLWorkbook(Path))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);

                //Create a new DataTable.
                DataTable table = new DataTable();

                //Loop through the Worksheet rows.
                bool firstRow = true;
                var startIndex = workSheet.FirstRowUsed().FirstCellUsed().Address.ColumnNumber;
                var endIndex = workSheet.FirstRowUsed().LastCellUsed().Address.ColumnNumber;
                foreach (IXLRow row in workSheet.RowsUsed())
                {
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        foreach (IXLCell cell in row.Cells())
                        {
                            table.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        //Add rows to DataTable.
                        table.Rows.Add();
                        int i = 0;

                        foreach (IXLCell cell in row.Cells(startIndex, endIndex))
                        {
                            table.Rows[table.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }
                }

                return table;
            }
        }
    }
}
