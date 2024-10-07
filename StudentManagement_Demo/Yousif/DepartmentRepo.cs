using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Demo.Yousif
{
    public class DepartmentRepo : IDepartmentRepository
    {

        public async Task<int> AddDepartmentAsync(Departments department)
        {
            using (StudentManagementDBEntities db = new StudentManagementDBEntities())
            {
                try
                {
                    db.Departments.Add(department);
                    db.SaveChanges();
                    return department.DepartmentID;

                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        public async Task<bool> DeleteDepartmentAsync(int departmentId )
        {
            using (StudentManagementDBEntities db = new StudentManagementDBEntities())
            {
                try
                {
                    Departments d = db.Departments.FirstOrDefault(x => x.DepartmentID == departmentId);
                    db.Departments.Remove(d);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }


        public async Task<IEnumerable<Departments>> GetAllDepartmentsAsync()
        {
            using (StudentManagementDBEntities db = new StudentManagementDBEntities())
            {
                try
                {
                    return db.Departments.ToList();

                }
                catch (Exception ex)
                {
                    return null;
                }
            }

        }

        public async Task<Departments> GetDepartmentByIdAsync(int departmentId)
        {
            using (StudentManagementDBEntities db = new StudentManagementDBEntities())
            {
                try
                {
                   
                   Departments d = db.Departments.FirstOrDefault(x => x.DepartmentID == departmentId);
                   
                   return d;


                }
                catch (Exception ex) 
                {
                    return null;
                }

            }
        }

        public async Task<bool> UpdateDepartmentAsync(Departments department)
        {
            using (StudentManagementDBEntities db = new StudentManagementDBEntities())
            {
                try
                {
                    Console.WriteLine("Enter Department Id :");
                    int x = int.Parse(Console.ReadLine());
                    var c = db.Departments.FirstOrDefault(z => z.DepartmentID == x);
                    Console.WriteLine($"Enter Department Name :");
                    c.DepartmentName = Console.ReadLine();
                    Console.WriteLine("Department code :");
                    c.DepartmentCode = Console.ReadLine();
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex) 
                {
                    return false;
                }
            }
        }
    }
}
   
    


