using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BITCollege_YSC.Data
{
    /// <summary>
    /// Represents the main database context which is responsible for interacting with the underlying database
    /// and provides DbSet properties for each entity type to be queried or saved.
    /// </summary>
    public class BITCollege_YSCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public BITCollege_YSCContext() : base("name=BITCollege_YSCContext")
        {
        }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.AcademicProgram> AcademicPrograms { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.GradePointState> GradePointStates { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.Registration> Registrations { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.GradedCourse> GradedCourses { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.AuditCourse> AuditCourses { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.MasteryCourse> MasteryCourses { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.SuspendedState> SuspendedStates { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.ProbationState> ProbationStates { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.RegularState> RegularStates { get; set; }

        public System.Data.Entity.DbSet<BITCollege_YSC.Models.HonoursState> HonoursStates { get; set; }
    }
}
