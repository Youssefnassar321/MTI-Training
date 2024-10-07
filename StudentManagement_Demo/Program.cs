using StudentManagement_Demo.Yousif;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Start The Program Press ==> Enter");
            Console.WriteLine("_________________________________________");
            Console.ReadKey();
            Console.WriteLine("");



           
            bool x = true;
            while (x)
            {
                Console.WriteLine("_________________________________________");
                Console.WriteLine("");
                Console.WriteLine("1:To ADD A Department Press ==> F1");
                Console.WriteLine("2:To List All The Departments Press ==> F2");
                Console.WriteLine("3:To Delete A Department Press ==> F3");
                Console.WriteLine("4:To Get A Department Press ==> F4");
                Console.WriteLine("5:To Update A Department Press ==> F5");
                Console.WriteLine("6:To ADD An Instructor Press ==> F6");
                Console.WriteLine("7:To List All The Instructors Press ==> F7");
                Console.WriteLine("8:To Delete An Instructor Press ==> F8");
                Console.WriteLine("9:To Get An Instructor Press ==> F9");
                Console.WriteLine("10:To Update An Instructor Press ==> F10");
                Console.WriteLine("11:To Stop The Program Press ==> Esc");
                Console.WriteLine("_________________________________________");
                

                ConsoleKey ky;
                ky = Console.ReadKey(true).Key;
                switch (ky)
                {
                    case ConsoleKey.F1:
                        functions.AddDepartment();
                        break;

                    case ConsoleKey.F2:
                        functions.listdepartment();
                        break;

                    case ConsoleKey.F3:
                        functions.deletedepartment();
                        break;

                    case ConsoleKey.F4:
                        functions.getdepartment();
                        break;

                    case ConsoleKey.F5:
                        functions.updatedepartment();
                        break;

                    case ConsoleKey.F6:
                        functions.addinstructor();
                        break;

                    case ConsoleKey.F7:
                        functions.listinstructors();
                        break;

                    case ConsoleKey.F8:
                        functions.deleteinstructor();
                        break;

                    case ConsoleKey.F9:
                        functions.getinstractor();
                        break;

                    case ConsoleKey.F10:
                        functions.updateinstructor();
                        break;

                    case ConsoleKey.Escape:
                        x = false;
                        Console.WriteLine("Exiting............");
                        break;

                    default:
                        Console.WriteLine("This button is not defined............");
                        break;

                }
            }
          
            
        }


    }
}
