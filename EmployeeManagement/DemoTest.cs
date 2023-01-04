using EmployeeManagement.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class DemoTest
    {

        public static object[] DemovalidData()
        {
            string[] dataSet1 = new string[2];//no of argument we have
                dataSet1[0] = "john";
            dataSet1[1] = "john123";

            string[] dataSet2 = new string[2];
                dataSet2[0] = "peter";
            dataSet2[1] = "peter123";

            string[] dataSet3 = new string[2];
                dataSet3[0] = "soul";
            dataSet3[1] = "soul123";

            object[] allDataSet = new object[3];//number of test cases we have
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
                allDataSet[2] = dataSet3;

            return allDataSet;

        }
        [Test, TestCaseSource(nameof(DemovalidData))]
        public void DemoValidLogin(string username,string password)
        {
            Console.WriteLine("Rakesh" +username+password);
        }
    }
}
