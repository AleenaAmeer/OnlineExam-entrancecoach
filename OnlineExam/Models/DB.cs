using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineExam.Models
{
    public class DB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> Roles { get; set; }

        public DbSet<StudentRegistration> StudentRegistrations { get; set; }
        public DbSet<StudentParent> StudentParents { get; set; }
        public DbSet<StudentHomeCountryDetails> StudentHomeCountryDetails { get; set; }
        public DbSet<StudentPreviousEntrance> StudentPreviousEntrances { get; set; }
        public DbSet<StudentAcademicPerformance> StudentAcademicPerformances { get; set; }

    }
}