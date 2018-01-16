namespace övning_11_Db
{
    using System.Data.Entity;

    public class peopleDb : DbContext
    {
        // Your context has been configured to use a 'peopleDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'övning_11_Db.peopleDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'peopleDb' 
        // connection string in the application configuration file.
        public peopleDb()
            : base("peopleDb")
        {
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