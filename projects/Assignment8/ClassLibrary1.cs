using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        public int EmpID;
        public string EmpName;
        public double SalaryPerHour;
        public double NoOfWorkingHours;
        public double NetSalary;
        public static string OrganizationName;
        public const string TypeOfEmployee = "Contract Based";
        public readonly string DepartmentName;
        

        public Employee()
        {
            DepartmentName = "Finance Department";
        }
    }
}
