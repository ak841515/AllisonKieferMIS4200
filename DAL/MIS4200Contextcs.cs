using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AllisonKieferMIS4200.Models;
using System.Data.Entity;

namespace AllisonKieferMIS4200.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            //add the Set Initializer statement here

           Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, AllisonKieferMIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Grade> Grade { get; set; }

       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Professor> Professor { get; set; }
    }
}





