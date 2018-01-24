namespace Övning11
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class PersonsDb : DbContext
    {


        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Övning11.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public PersonsDb()
            : base("PersonsDb")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PersonsDb>());
        }


        public class Model1Initializer : CreateDatabaseIfNotExists<PersonsDb>
        {
            protected override void Seed(PersonsDb context)
            {
                IList<Person> personList = new List<Person>();


                personList.Add(new Person { Age = 23 });
                personList.Add(new Person { Age = 12 });
                personList.Add(new Person { Age = 45 });
                personList.Add(new Person { Age = 45 });
                personList.Add(new Person { Age = 75 });
                personList.Add(new Person { Age = 3 });
                personList.Add(new Person { Age = 6 });
                personList.Add(new Person { Age = 10 });
                personList.Add(new Person { Age = 32 });
                personList.Add(new Person { Age = 5 });
                personList.Add(new Person { Age = 80 });

                foreach (Person s in personList)
                {
                    context.persons.Add(s);
                }
                //context.SaveChanges();
                base.Seed(context);
            }
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Person> persons { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}