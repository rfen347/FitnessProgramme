namespace FitnessProgramme.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Customer : DbContext
    {
        // Your context has been configured to use a 'Customer' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FitnessProgramme.Models.Customer' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Customer' 
        // connection string in the application configuration file.
        public Customer()
            : base("name=Customer")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Programme { get; set; }
        public int age { get; set; }
        public string Gender { get; set; }
    }
}