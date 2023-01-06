using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class DataSource
    {
        public static object[] InvalidLoginData()
        {
            string[] dataSet1 = new string[3];//no of argument we have
            dataSet1[0] = "john";
            dataSet1[1] = "john123";
            dataSet1[2] = "Invalid credential";
            string[] dataSet2 = new string[3];
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";
            dataSet2[2] = "Invalid credential";
            string[] dataSet3 = new string[3];
            dataSet3[0] = "soul";
            dataSet3[1] = "soul123";
            dataSet3[2] = "Invalid credential";
            object[] allDataSet = new object[3];//number of test cases we have
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;

            return allDataSet;

        }
        public static object[] ValidEmployeeNameTest() 
        {
            string[] dataSet1 = new string[6];//no of argument we have
            dataSet1[0] = "Admin";
            dataSet1[1] = "admin123";
            dataSet1[2] = "john";
            dataSet1[3] = "w";
            dataSet1[4] = "wick";
            dataSet1[5] = "john wick";

            string[] dataSet2 = new string[6];//no of argument we have
            dataSet2[0] = "Admin";
            dataSet2[1] = "admin123";
            dataSet2[2] = "saul";
            dataSet2[3] = "g";
            dataSet2[4] = "goodman";
            dataSet2[5] = "saul goodman";

            


            object[] allDataSet = new object[2];//number of test cases we have
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
           

            return allDataSet;
        }
        public static object[] InvalidLoginData2()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray(@"C:\Users\rakeshro\Desktop\C# SESSION\AutomationFramework\EmployeeManagement\TestData\OrangeHRM_data.xlsx", "InvalidLoginTest");
            return data;
        }
        public static object[] ValidEmployeeNameTest2()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray("C:\\Users\\rakeshro\\Desktop\\C# SESSION\\AutomationFramework\\EmployeeManagement\\TestData\\OrangeHRM_data.xlsx", "AddValidEmployee");
            return data;
        }
    }
}
