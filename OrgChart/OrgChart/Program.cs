using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart
{

    class Employee
    {
        public string name { get; set; }
        public int reportCount { get; set; }

    }
    class EmployeeType
    {
        public List<Employee> EmployeeList { get; set; }

        public EmployeeType()
        {
            EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee { name = "Bill", reportCount = 3 });
            EmployeeList.Add(new Employee { name = "Sam", reportCount = 0 });
            EmployeeList.Add(new Employee { name = "Fred", reportCount = 1 });
            EmployeeList.Add(new Employee { name = "Jane", reportCount = 0 });
            EmployeeList.Add(new Employee { name = "Alice", reportCount = 0 });


            foreach (var item in EmployeeList) ;
        }
        public Employee Lookup(string name)
        {

            for (int i = 0; i < EmployeeList.Count; i++) 

            if (EmployeeList[i].name == name)

                return EmployeeList[i];
        
       

            return null;
    }
        






class Program
        {
            private static int reportCount;

            static void Main(string[] args)
            {
                Debug.Assert(new EmployeeType().Lookup("Bill").reportCount == 3, "Good Job"); 
            }
        }
    }
}