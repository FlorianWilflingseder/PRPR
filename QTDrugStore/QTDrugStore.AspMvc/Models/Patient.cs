using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QTDrugStore.AspMvc.Models
{
    public class Patient : VersionModel
    {

        [NotMapped]
        public DateTime Birthday
        {
            get
            {
                int day = Convert.ToInt32(SocialSecurityNumber.Substring(4, 2));
                int month = Convert.ToInt32(SocialSecurityNumber.Substring(6, 2));
                int year = Convert.ToInt32(SocialSecurityNumber.Substring(8, 2))+ 1900;
             
                return new DateTime(year, month, day);
            }
        }

        [MaxLength(10)]
        public string SocialSecurityNumber { get; set; } = String.Empty;

        [MaxLength(64)]
        public string FirstName { get; set; } = String.Empty;

        [MaxLength(64)]
        public string LastName { get; set; } = String.Empty;


    }
}
