using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Demo.Yousif
{
    internal class InstructorRepo : IInstructorRepository
    {
        public async Task<int> AddInstructorAsync(Instructors instructor)
        {
            using (StudentManagementDBEntities db = new StudentManagementDBEntities())
            {
                try
                {
                    db.Instructors.Add(instructor);
                    db.SaveChanges();
                    return instructor.InstructorID;
                }
                catch (Exception ex)
                {
                    return 0;

                }
            }
        }

        public async Task<bool> DeleteInstructorAsync(int instructorId)
        {
            using (StudentManagementDBEntities db = new StudentManagementDBEntities())
            {
                try
                {
                    Instructors i = db.Instructors.FirstOrDefault(x => x.InstructorID == instructorId);
                    db.Instructors.Remove(i);
                    db.SaveChanges();
                    return true;


                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public async Task<IEnumerable<Instructors>> GetAllInstructorsAsync()
        {
            using (StudentManagementDBEntities db = new StudentManagementDBEntities()) 
            {
                try
                {
                    return db.Instructors.ToList();
                    
                }
                catch (Exception ex) 
                {
                    return null;
                    
                }
            }
        }

        public async Task<Instructors> GetInstructorByIdAsync(int instructorId)
        {
            using(StudentManagementDBEntities db = new StudentManagementDBEntities()) 
            {
                try
                {
                    Instructors i = db.Instructors.FirstOrDefault(x => x.InstructorID == instructorId);
                    return i ;
                }
                catch (Exception ex) 
                {
                    return null;
                }
            }
        }

        public async Task<bool> UpdateInstructorAsync(Instructors instructor)
        {
            using (StudentManagementDBEntities db = new StudentManagementDBEntities())
            {
                try
                {
                    
                    //db.Instructors.FirstOrDefault(x => x.InstructorID == instructor.InstructorID);
                    if (db.Instructors.Find(instructor.InstructorID) == null)
                    {
                        throw new InvalidOperationException("Instructor Doesenot Exixst");
                    }
                    else
                    {
                        db.Instructors.AddOrUpdate(instructor);
                        db.SaveChanges();
                        return true;
                    }

                    //db.Instructors.AddOrUpdate(instructor);
                    //db.SaveChanges();
                    //return true;
                }
                catch (Exception ex)
                {
                    return false;

                }
            }
        }
    }
}
