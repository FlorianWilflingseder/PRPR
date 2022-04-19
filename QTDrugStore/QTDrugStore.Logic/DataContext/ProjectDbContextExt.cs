using QTDrugStore.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugStore.Logic.DataContext
{
    partial class ProjectDbContext 
    {
        public DbSet<Patient>? PatientSet { get; set; }

        partial void GetDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : Entities.IdentityEntity
        {
            if(typeof(E)== typeof(Patient))
            {
                handled = true; 
                dbSet = PatientSet as DbSet<E>;
            }
        }
    }
}
