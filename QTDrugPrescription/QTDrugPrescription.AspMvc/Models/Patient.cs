using System.ComponentModel.DataAnnotations;

namespace QTDrugPrescription.AspMvc.Models
{
    public class Patient : VersionModel
    {
   
        [MaxLength(64)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(64)]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string SocialSecurityNumber { get; set; } = string.Empty;
    }
}
