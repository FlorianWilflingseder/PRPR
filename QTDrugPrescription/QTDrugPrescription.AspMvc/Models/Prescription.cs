using System.ComponentModel.DataAnnotations;

namespace QTDrugPrescription.AspMvc.Models
{
    public class Prescription : VersionModel
    {
        public int PatientId { get; set; }


        public int DrugId { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(1024)]
        string Dosing { get; set; } = string.Empty;

        public string DrugNumber { get; set; } = string.Empty;
        public string PatientSSN { get; set; } = string.Empty;

        public Logic.Entities.Drug[]? Drugs { get; set; }
        public Logic.Entities.Patient[]? Patients { get; set; }
    }
}
