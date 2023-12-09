using ConsoleEF_CodeFirst.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace ConsoleEF_CodeFirst
{
    public class EFModel : DbContext
    {
        // Your context has been configured to use a 'EFModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ConsoleEF_CodeFirst.EFModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EFModel' 
        // connection string in the application configuration file.
        public EFModel()
            : base("name=EFModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MyEntity> MyEntities { get; set; }

        // Tony: EF Code First，有修改此Entity Model 時，要執行 PM> update-database -Verbose
        public virtual DbSet<UserModel> Users { get; set; }
    }

    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}