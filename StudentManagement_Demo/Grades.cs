//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement_Demo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grades
    {
        public int GradeID { get; set; }
        public int EnrollmentID { get; set; }
        public string Grade { get; set; }
        public System.DateTime GradeDate { get; set; }
    
        public virtual Enrollments Enrollments { get; set; }
    }
}
