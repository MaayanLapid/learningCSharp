using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaayanBank.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = null;
            string password = null;

            Console.WriteLine("*********** Maayan Bank *************");
            Console.WriteLine("::Login Page::");
            Console.WriteLine("Press Enter to Exit");
            Console.Write("Enter Username: ");
            userName = Console.ReadLine();

            // Console.WriteLine("Your Username is: " + userName);

            if (userName != "")
            {
                Console.Write("Enter Your Password: ");
                password = Console.ReadLine();
            }

            if (userName == "admin" && password == "1234")
            {
                    int mainMenuChoise = -1;
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine(":::Main Menu:::");
                    Console.WriteLine("1.Customer");
                    Console.WriteLine("2.Accounts");
                    Console.WriteLine("3.funds Transfer");
                    Console.WriteLine("4.funds Transfer Statment");
                    Console.WriteLine("5.Account Statment");
                    Console.WriteLine("0.Exit");

                    Console.Write("Enter Your Choice: ");
                    mainMenuChoise = Convert.ToInt32(Console.ReadLine());


                    switch (mainMenuChoise)
                    {
                        case 1:
                            customerMenuChoise();
                            break;
                        case 2:
                            accountsMenuChoise();
                            break;
                        case 3:
                            Console.WriteLine("3.funds Transfer Menu");
                            break;
                        case 4:
                            Console.WriteLine("4.funds Transfer Statment Menu");
                            break;
                        case 5:
                            Console.WriteLine("5.Account Statment Menu");
                            break;
                        case 0:
                            Console.WriteLine("0.Exit Menu");
                            break;
                        default:
                            Console.WriteLine("Invalid Choise");
                            break;
                    }
                    
                } while (mainMenuChoise != 0);
            }
            Console.WriteLine("Good bye");

            Console.ReadKey();
        }
        static void customerMenuChoise()
        {
            int customerMenuChoise = -1;

            do
            {
                Console.WriteLine("\n::::Customer Menu::::");
                Console.WriteLine("1.Add Customer");
                Console.WriteLine("2.Delete Customer");
                Console.WriteLine("3.Update Customer");
                Console.WriteLine("4.View Customer");
                Console.WriteLine("0.Back to Main Menu");
                Console.Write("Enter Your Choice: ");
                customerMenuChoise = Convert.ToInt32(Console.ReadLine());
            } while (customerMenuChoise != 0);
        }
        static void accountsMenuChoise()
        {
            int accountsMenuChoise = -1;

            do
            {
                Console.WriteLine("\n::::Account Menu::::");
                Console.WriteLine("1.Add Account");
                Console.WriteLine("2.Delete Account");
                Console.WriteLine("3.Update Account");
                Console.WriteLine("4.View Account");
                Console.WriteLine("0.Back to Main Menu");
                Console.Write("Enter Your Choice: ");
                accountsMenuChoise = Convert.ToInt32(Console.ReadLine());
            } while (accountsMenuChoise != 0);
        }
    }
}
