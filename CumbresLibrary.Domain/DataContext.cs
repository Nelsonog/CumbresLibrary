using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumbresLibrary.Domain
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class DataContext : DbContext
    {
        #region Properties
        public DbSet<User> Users { get; set; }

        public DbSet<UserType> UserTypes { get; set; }

        public DbSet<StatusItemBook> StatusItemBooks { get; set; }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<ItemBook> ItemBook { get; set; }

        public DbSet<Editorial> Editorials { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

       // public DbSet<Prediction> Predictions { get; set; }
        #endregion

        #region Constructors
        public DataContext() : base("DefaultConnection")
        {
        }
        #endregion

        #region Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new OperationsMap());
        }
        #endregion
    }
}
