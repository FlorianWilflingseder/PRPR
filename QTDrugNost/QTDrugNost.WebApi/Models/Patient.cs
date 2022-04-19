using System.ComponentModel.DataAnnotations;

namespace QTDrugNost.WebApi.Models
{
    public class Patient : VersionModel
    {
        [MaxLength(10)]
        public string SocialSecurityNumber { get; set; } = String.Empty;

        [MaxLength(64)]
        public string FirstName { get; set; } = String.Empty;

        [MaxLength(64)]
        public string LastName { get; set; } = String.Empty;
    }
}
