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

            for(int r = 2; r <=4;r++)
            {
                for(int c=1;c<=3;c++)
                {
                    //string[] dataset1 = new string[3];
                    //dataset1[0] = "john";
                    //dataset1[1] = "john123";
                    //dataset1[2] = "Invalid Credential";
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                 
                }


                
               
            }



            
            book.Dispose();

        }
    }
}
