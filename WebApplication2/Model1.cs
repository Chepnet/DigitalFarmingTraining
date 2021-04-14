namespace WebApplication2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<FarmersTraining> FarmersTrainings { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FarmersTraining>()
                .Property(e => e.TrainerName)
                .IsUnicode(false);

            

            modelBuilder.Entity<FarmersTraining>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<FarmersTraining>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);
            
        }

       

        public System.Data.Entity.DbSet<WebApplication2.Models.TrainingApplication> TrainingApplications { get; set; }
    }
}
