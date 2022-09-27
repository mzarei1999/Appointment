using Appointment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Appointment.DataLayer
{

    public class EFDataContext: DbContext
    {


        public EFDataContext(DbContextOptions<EFDataContext> options) : base(options)
        {
        }


        //public EFDataContext(string connectionString)
        //    : this(new DbContextOptionsBuilder<EFDataContext>().UseSqlServer(connectionString).Options)
        //{
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFDataContext).Assembly);
        }

        public override ChangeTracker ChangeTracker
        {
            get
            {
                var tracker = base.ChangeTracker;
                tracker.LazyLoadingEnabled = false;
                tracker.AutoDetectChangesEnabled = true;
                tracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
                return tracker;
            }
        }

        public DbSet<Blog> Blogs { get; set; }



        
    }
}
