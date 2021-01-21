using Bag_Tracer.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Bag_Tracer.Model
{
    class DataContext : DbContext
    {
        #region Constructors



        #endregion

        #region Members



        #endregion

        #region Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(StaticGlobals.GetConnectionString())
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO
        }

        #endregion
    }
}
