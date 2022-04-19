using QTBookStoreLight.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTBookStoreLight.Logic.DataContext
{
    partial class ProjectDbContext
    {
        public DbSet<Book> books { get; set; }

        partial void GetDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : Entities.IdentityEntity
        {
            if(typeof(E) == typeof(Book))
            {
                handled = true;
                dbSet = books as DbSet<E>;
            }
        }

    }
}
