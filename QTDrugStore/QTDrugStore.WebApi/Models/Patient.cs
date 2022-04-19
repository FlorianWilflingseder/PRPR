using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QTDrugStore.WebApi.Models
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
