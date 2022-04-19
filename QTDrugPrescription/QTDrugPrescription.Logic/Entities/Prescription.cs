using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Entities
{
    [Table("Prescriptions", Schema = "App")]
    
    public class Prescription : VersionEntity
    {
        
        public int PatientId { get; set; }

        
        public int DrugId { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(1024)]
        string Dosing { get; set; } = string.Empty;

        public Patient? Patient { get; set; }
        public Drug? Drug { get; set; }
    }
}
