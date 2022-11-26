using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Assignment8WorkingwithMultipleObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialazing a Static Field
            Employee.OrganizationName = "Harsha Inc.";

            for (int i = 0; i < 10; i++)
            {
                int employeeNum = 0;
                string userChoice;

                switch (i)
                {
                    case 0: employeeNum = 1; break;
                    case 1: employeeNum = 2; break;
                    case 2: employeeNum = 3; break;
                    case 3: employeeNum = 4; break;
                    case 4: employeeNum = 5; break;
                    case 5: employeeNum = 6; break;
                    case 6: employeeNum = 7; break;
                    case 7: employeeNum = 8; break;
                    case 8: employeeNum = 9; break;
                    case 9: employeeNum = 10; break;
                    default: Console.WriteLine("something went wrong"); break;
                }

                //Creating Reference Variables & Object
                Employee employee = new Employee();

                //Displaying the employee number
                Console.WriteLine("Empotee Number: " + employeeNum);

                //Input from the User
                Console.Write("Enter ID: ");
                employee.EmpID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                employee.EmpName = Console.ReadLine();

                Console.Write("Enter Salary Per Hour: ");
                employee.SalaryPerHour = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number Of Working Hours: ");
                employee.NoOfWorkingHours = Convert.ToInt32(Console.ReadLine());

                //Calculating the Net Salary of an employee
                employee.NetSalary = employee.SalaryPerHour * employee.NoOfWorkingHours;

                //Displaying the employee details
                Console.WriteLine();
                Console.WriteLine("Employe ID:" + employee.EmpID);
                Console.WriteLine("Employe Name:" + employee.EmpName);
                Console.WriteLine("Employe Salary Per Hour:" + employee.SalaryPerHour);
                Console.WriteLine("Employe Number Of Working Hours:" + employee.NoOfWorkingHours);
                Console.WriteLine("Employe Net Salary:" + employee.NetSalary);
                Console.WriteLine("Employe Organization Name: " + Employee.OrganizationName);
                Console.WriteLine("Employe Type : " + Employee.TypeOfEmployee);
                Console.WriteLine("Employe Department Name: " + employee.DepartmentName);

                Console.WriteLine("Do you want to continue to next employee ? Yes | No ");
                userChoice = Console.ReadLine();

                Console.ReadKey();

                if (userChoice == "no")
                {
                    break;
                }


            }

        }
    }
    //Create a console application that stores and displays 10 employees information of Harsha Inc.Class Library:
    //Contains Employee class.
    //Console Application: Consumes the Employee class and creates 10 objects of Employee class.

    //Step 1: Create a class library and console application.Add reference of class library into console application.

    //Step 2: Create a class called Employee in the class library with fields EmpID, EmpName, SalaryPerHour, NoOfWorkingHours and NetSalary.Additionally, add the following fields:
    //    - A static field called OrganizationName.It should be initialized as "Harsha Inc." in Main method.
    //    - A constant field called TypeOfEmployee and initialize it as "Contract Based" along with declaration.
    //    - A readonly field called DepartmentName and initialize it as "Finance Department" in constructor.

    //Step 3: Create up to 10 objects of Employee class in the console application.Read each employee details(EmpID, EmpName, SalaryPerHour, NoOfWorkingHours) from the user(from the keyboard) using loop.

    //Calculate net salary(SalaryPerHour* NoOfWorkingHours).

    //And display the all details of the same object (including EmpID, EmpName, SalaryPerHour, NoOfWorkingHours, NetSalary, OrganizationName, TypeOfEmployee, DepartmentName) and then ask the user 'Do you want to continue to next employee'.

    //If the user choose 'Yes', proceed to the next employee; otherwise stop the loop.
}
