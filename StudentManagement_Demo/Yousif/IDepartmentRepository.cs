using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement_Demo;
namespace StudentManagement_Demo.Yousif
{
    public interface IDepartmentRepository
    {
        /// <summary>
        /// Gets a department by its ID.
        /// </summary>
        /// <param name="departmentId">The unique ID of the department.</param>
        /// <returns>The department object if found, null otherwise.</returns>
        Task<Departments> GetDepartmentByIdAsync(int departmentId);

        /// <summary>
        /// Gets all departments.
        /// </summary>
        /// <returns>A list of all departments.</returns>
        Task<IEnumerable<Departments>> GetAllDepartmentsAsync();

        /// <summary>
        /// Adds a new department.
        /// </summary>
        /// <param name="department">The department object to add.</param>
        /// <returns>The ID of the newly created department.</returns>
        Task<int> AddDepartmentAsync(Departments department);

        /// <summary>
        /// Updates an existing department.
        /// </summary>
        /// <param name="department">The department object with updated information.</param>
        /// <returns>True if the update was successful, false otherwise.</returns>
        Task<bool> UpdateDepartmentAsync(Departments department);

        /// <summary>
        /// Deletes a department by its ID.
        /// </summary>
        /// <param name="departmentId">The ID of the department to delete.</param>
        /// <returns>True if the deletion was successful, false otherwise.</returns>
        Task<bool> DeleteDepartmentAsync(int departmentId);
    }
}
