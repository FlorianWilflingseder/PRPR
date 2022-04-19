using QTWiederholungNOST.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTWiederholungNOST.Logic.DataContext
{
    partial class ProjectDbContext
    {
        public DbSet<Patient>? PatientSet { get; set; }

        partial void GetDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : Entities.IdentityEntity
        {
            if(typeof(Patient) == typeof(E))
            {
                dbSet = PatientSet as DbSet<E>;
                handled = true;
            }
        }
    }
}
