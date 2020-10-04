namespace FIT5032Assignment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FIT5032Assignment_Models : DbContext
    {
        public FIT5032Assignment_Models()
            : base("name=FIT5032Assignment_Models")
        {
        }

        public virtual DbSet<Exercis> Exercises { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
