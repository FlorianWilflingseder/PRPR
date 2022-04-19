using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Entities
{
    [Table("Patients", Schema = "App")]
    [Index(nameof(SocialSecurityNumber), IsUnique = true)]
    public class Patient : VersionEntity
    {
        [NotMapped]
        public DateTime Birthday { get; set; } 

        [MaxLength(64)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(64)]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string SocialSecurityNumber { get; set; } = string.Empty;

        public List<Prescription> Prescriptions { get; set; } = new();
    }
}
