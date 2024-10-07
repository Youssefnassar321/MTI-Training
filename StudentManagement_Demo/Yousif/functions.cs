using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Demo.Yousif
{
    public class functions : DepartmentRepo
    {


        #region Add Department
        public static async Task AddDepartment()
        {

            Console.WriteLine("Enter Department Name :");
            string n = Console.ReadLine();

            Console.WriteLine("Department code :");
            string c = Console.ReadLine();

            Departments d = new Departments()
            {

                DepartmentName = n,
                DepartmentCode = c

            };

            DepartmentRepo Repo = new DepartmentRepo();
            await Repo.AddDepartmentAsync(d);
            Console.WriteLine("******The Deparment Is Add Scussfully******");

        }
        #endregion

        #region List Department
        public static async Task listdepartment()
        {

            DepartmentRepo repo = new DepartmentRepo();
            var departments = await repo.GetAllDepartmentsAsync();
            foreach (var item in departments)
            {
                Console.WriteLine($"Department ID : {item.DepartmentID}");
                Console.WriteLine($"Department Name: {item.DepartmentName}");
                Console.WriteLine($"Department Code: {item.DepartmentCode}");
                Console.WriteLine("");
            }
        }
        #endregion

        #region Delete Department
        public static async Task deletedepartment()
        {

            DepartmentRepo repo = new DepartmentRepo();
            Console.WriteLine("Enter Department Id :");
            int DepartmentID = int.Parse(Console.ReadLine());


            bool x = await repo.DeleteDepartmentAsync(DepartmentID);

            if (x == true)
            {

                Console.WriteLine("******The Department Is Deleted Scussfully******");
            }
            else
            {
                Console.WriteLine("******The Id Is Not Found******");
            }

        }
        #endregion

        #region Get Department
        public static async Task getdepartment()
        {
            DepartmentRepo repo = new DepartmentRepo();
            Console.WriteLine("Enter Department Id :");

            int DepartmentID = int.Parse(Console.ReadLine());
            Console.WriteLine("_________________________________________");

            var dd = await repo.GetDepartmentByIdAsync(DepartmentID);
            if (dd == null)
            {
                Console.WriteLine("******The Id Is Not Found******");
            }
            else
            {
                Console.WriteLine($"The Id : {dd.DepartmentID}");
                Console.WriteLine($"Department Name :{dd.DepartmentName}");
                Console.WriteLine($"Department Code :{dd.DepartmentCode}");
            }

        }
        #endregion

        #region Update Department
        public static async Task updatedepartment()
        {
            

            Departments d = new Departments();

            Console.WriteLine("Enter Department Id :");
            d.DepartmentID = int.Parse(Console.ReadLine());


            Console.WriteLine($"Enter Department Name :");
            d.DepartmentName = Console.ReadLine();
            Console.WriteLine("Department code :");
            d.DepartmentCode = Console.ReadLine();

            DepartmentRepo repo = new DepartmentRepo();
            await repo.UpdateDepartmentAsync(d.DepartmentID);

        }
        #endregion

        #region Add Instructor
        public static async Task addinstructor()
        {
            Console.WriteLine("Add First Name :");
            string f = Console.ReadLine();
            Console.WriteLine("Add Last Name : ");
            string l = Console.ReadLine();
            Console.WriteLine("Add Email :");
            string e = Console.ReadLine();


            Instructors i = new Instructors()
            {
                FirstName = f,
                LastName = l,
                Email = e,
                HireDate = DateTime.Now

            };


            InstructorRepo repo = new InstructorRepo();
            await repo.AddInstructorAsync(i);
            Console.WriteLine("******The Instructor Is Add Scussfully******");
        }
        #endregion

        #region List Instructor
        public static async Task listinstructors()
        {
            InstructorRepo repo = new InstructorRepo();
            var instructors = await repo.GetAllInstructorsAsync();

            foreach (var item in instructors)
            {
                Console.WriteLine($"The Id : {item.InstructorID}");
                Console.WriteLine($"The First Name : {item.FirstName}");
                Console.WriteLine($"The Last Name : {item.LastName}");
                Console.WriteLine($"Email : {item.Email}");
                Console.WriteLine($"The Hier Date : {item.HireDate}");
                Console.WriteLine("");
            }
        }
        #endregion

        #region Delete Instructor
        public static async Task deleteinstructor()
        {
            InstructorRepo repo = new InstructorRepo();
            Console.WriteLine("Enter Id");
            int x = int.Parse(Console.ReadLine());
            bool y = await repo.DeleteInstructorAsync(x);
            if (y == true)
            {
                Console.WriteLine("******The Instractor is Deleted Sucssfully****** ");
            }
            else
            {
                Console.WriteLine("******The Id Is Not Found****** ");
            }
        }
        #endregion

        #region Get Instractor
        public static async Task getinstractor()
        {
            InstructorRepo repo = new InstructorRepo();
            Console.WriteLine("Enter id ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("_________________________________________");
            var i = await repo.GetInstructorByIdAsync(x);
            if (i == null)
            {
                Console.WriteLine("******The Id Is Not Found****** ");
            }
            else
            {
                Console.WriteLine($"The Id : {i.InstructorID}");
                Console.WriteLine($"The First Name : {i.FirstName}");
                Console.WriteLine($"The Last Name : {i.LastName}");
                Console.WriteLine($"Email : {i.Email}");
                Console.WriteLine($"The Hier Date : {i.HireDate}");
            }
        }
        #endregion

        #region Update Instructor
        public static async Task updateinstructor()
        {
            InstructorRepo repo = new InstructorRepo();

            Console.WriteLine("Enter Id :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Add First Name : ");
            string f = Console.ReadLine();
            Console.WriteLine("Add Last Name : ");
            string l = Console.ReadLine();
            Console.WriteLine("Add Email :");
            string e = Console.ReadLine();

            Instructors i = new Instructors()
            {
                InstructorID = x,
                FirstName = f,
                LastName = l,
                Email = e,
                HireDate = DateTime.Now
            };
            await repo.UpdateInstructorAsync(i);

        }
    } 
    #endregion


}



           