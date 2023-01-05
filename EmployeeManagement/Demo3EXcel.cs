using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
namespace EmployeeManagement
{

    public class Demo3EXcel
    {
        [Test]
        public void DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook(@"C:\\Users\\rakeshro\\Desktop\\C# SESSION\\AutomationFramework\\EmployeeManagement\\TestData\\OrangeHRM_data.xlsx");
            IXLWorksheet sheet = book.Worksheet("InvalidLoginTest");
            IXLRange range = sheet.RangeUsed();
            string value=range.Cell(1,1).GetString();
            Console.WriteLine(value);
            book.Dispose();

        }
    }
}
