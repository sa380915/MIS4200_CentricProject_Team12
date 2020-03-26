using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200_CentricProject_Team12.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MIS4200_CentricProject_Team12.DAL
{
    public class MIS4200Context : DbContext
    {

        public MIS4200Context() : base("name=DefaultConnection")
        {
        // this method is a 'constructor' and is called when a new context is created
        // the base attribute says which connection string to use
        //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, sa380915MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));

        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Recognition> Recognitions { get; set; }
        public DbSet<recognitionDetails> RecognitionDetails { get; set; }


        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}