using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MySchoolProject
{
    class SchoolContext : DbContext
    {
        public SchoolContext() 
            : base ("MySchoolContext")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<SchoolContext>());

        }
       
        public DbSet <School> Schools { get; set; }
    }
}
