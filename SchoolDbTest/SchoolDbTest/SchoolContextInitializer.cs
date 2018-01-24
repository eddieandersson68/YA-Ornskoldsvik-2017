using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SchoolDbTest
{
    public class SchoolContextInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            IList<School> defaultSchools = new List<School>();
            defaultSchools.Add(new School { SchoolName = "Mitthögskolan:", Adress = "Västravägen 12"});
            defaultSchools.Add(new School { SchoolName = "Chalmers:", Adress = "KungsBron 3"});
            defaultSchools.Add(new School { SchoolName = "KTH:", Adress = "Strandvägen 24"});
            foreach (School s in defaultSchools)
            {
                context.Schools.Add(s);
            }

            context.Schools.AddRange(defaultSchools);
            //context.SaveChanges();
            base.Seed(context);
        }
    }
}
