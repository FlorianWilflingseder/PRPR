using System.ComponentModel.DataAnnotations;

namespace QTDrugPrescription.AspMvc.Models
{
    public class Drug : VersionModel
    {
        [MaxLength(10)]
        public string Number { get; set; } = string.Empty;

        [MaxLength(128)]
        public string Designation { get; set; } = string.Empty;

        [MaxLength(2048)]
        public string Note { get; set; } = string.Empty;
    }
}
