using System.ComponentModel.DataAnnotations;

namespace QTWiederholungNOST.WebApi.Models
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
