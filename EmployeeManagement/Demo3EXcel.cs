using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using EmployeeManagement.Base;

namespace EmployeeManagement
{

    public class Demo3EXcel: AutomationWrapper

    {
        [Test]
        public void DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook(@"C:\\Users\\rakeshro\\Desktop\\C# SESSION\\AutomationFramework\\EmployeeManagement\\TestData\\OrangeHRM_data.xlsx");
            IXLWorksheet sheet = book.Worksheet("InvalidLoginTest");
            IXLRange range = sheet.RangeUsed();
            

           // object[] alldata = new object[3];


            for (int r = 2; r <= 4; r++)
            {
              //  string[] dataset = new string[3];
                for (int c = 1; c <= 3; c++)
                {
                    
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                  //  dataset[c - 1] = value;

                }

              //  alldata[r - 2] = dataset;
            }

            //return alldata;



           // book.Dispose();

        }
    }
}
