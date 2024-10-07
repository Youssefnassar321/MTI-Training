using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Demo.Yousif
{
    public interface IInstructorRepository
    {
        /// <summary>
        /// Gets an instructor by their ID.
        /// </summary>
        /// <param name="instructorId">The unique ID of the instructor.</param>
        /// <returns>The instructor object if found, null otherwise.</returns>
        Task<Instructors> GetInstructorByIdAsync(int instructorId);

        /// <summary>
        /// Gets all instructors.
        /// </summary>
        /// <returns>A list of all instructors.</returns>
        Task<IEnumerable<Instructors>> GetAllInstructorsAsync();

        /// <summary>
        /// Adds a new instructor.
        /// </summary>
        /// <param name="instructor">The instructor object to add.</param>
        /// <returns>The ID of the newly created instructor.</returns>
        Task<int> AddInstructorAsync(Instructors instructor);

        /// <summary>
        /// Updates an existing instructor.
        /// </summary>
        /// <param name="instructor">The instructor object with updated information.</param>
        /// <returns>True if the update was successful, false otherwise.</returns>
        Task<bool> UpdateInstructorAsync(Instructors instructor);

        /// <summary>
        /// Deletes an instructor by their ID.
        /// </summary>
        /// <param name="instructorId">The ID of the instructor to delete.</param>
        /// <returns>True if the deletion was successful, false otherwise.</returns>
        Task<bool> DeleteInstructorAsync(int instructorId);
    }
}
