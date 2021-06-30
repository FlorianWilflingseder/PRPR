using Microsoft.EntityFrameworkCore;

namespace EventManager.Logic.DataContext
{
    partial class ProjectDbContext
    {
        public DbSet<Entities.EventManager.Event> Event { get; set; }

        partial void GetDbSet<C, E>(ref DbSet<E> dbset) where E : class
        {
            if (typeof(C) == typeof(EventManager.Contracts.Persistence.EventManager.IEvent))
            {
                dbset = Event as DbSet<E>;
            }
        }

        partial void BeforeOnModelCreating(ModelBuilder modelBuilder, ref bool handled)
        {
            var eventbuilder = modelBuilder.Entity<Entities.EventManager.Event>();

            eventbuilder.HasKey(p => p.Id);
            eventbuilder.Property(p => p.RowVersion);
            eventbuilder.Property(p => p.StartingAt).IsRequired(true);
            eventbuilder.Property(p => p.EndingAt).IsRequired(true);
            eventbuilder.Property(p => p.Name).IsRequired(true).HasMaxLength(256);
            eventbuilder.HasIndex(p => p.Description).IsUnique(true);
        }
    }
}
