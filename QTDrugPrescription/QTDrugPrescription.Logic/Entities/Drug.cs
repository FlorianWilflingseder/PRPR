using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Entities
{
    [Table("Drugs", Schema = "App")]
    [Index(nameof(Number), IsUnique = true)]
    public class Drug : VersionEntity
    {
        [MaxLength(10)]
        public string Number { get; set; } = string.Empty;

        [MaxLength(128)]
        public string Designation { get; set; } = string.Empty ;

        [MaxLength(2048)]
        public string Note { get; set; } = string.Empty;


        public List<Prescription> Prescriptions { get; set; } = new();
    }
}
