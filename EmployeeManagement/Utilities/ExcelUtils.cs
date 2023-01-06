using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class ExcelUtils

    {
        public static object[] GetSheetIntoObjectArray(string file, string sheetName)
        {
            using (XLWorkbook book = new XLWorkbook(file))
            {
                IXLWorksheet sheet = book.Worksheet(sheetName);

                IXLRange range = sheet.RangeUsed();

                int rowCount = range.RowCount();
                int columnCount = range.ColumnCount();

                object[] allData = new object[rowCount - 1];

                for (int r = 2; r <= rowCount; r++)
                {
                    string[] arr = new string[columnCount];

                    for (int c = 1; c <= columnCount; c++)
                    {
                        string value = range.Cell(r, c).GetString();
                        Console.WriteLine(value);
                        arr[c - 1] = value;
                    }
                    allData[r - 2] = arr;
                }
                return allData;
            }
        }
    }
}


