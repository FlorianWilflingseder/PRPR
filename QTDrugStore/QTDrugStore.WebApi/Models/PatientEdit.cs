using System.ComponentModel.DataAnnotations;

namespace QTDrugStore.WebApi.Models
{
    public class PatientEdit
    {
      
        [MaxLength(10)]
        public string SocialSecurityNumber { get; set; } = String.Empty;

        [MaxLength(64)]
        public string FirstName { get; set; } = String.Empty;

        [MaxLength(64)]
        public string LastName { get; set; } = String.Empty;
    }
}
