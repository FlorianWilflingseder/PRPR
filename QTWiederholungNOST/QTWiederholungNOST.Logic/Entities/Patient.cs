using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTWiederholungNOST.Logic.Entities
{
    [Table("Patients",Schema = "App")]
    [Index(nameof(SocialSecurityNumber),IsUnique = true)]
    public class Patient : VersionEntity
    {
        [NotMapped]
        public DateTime BirthDay { get; }

        [MaxLength(10)]
        public string SocialSecurityNumber { get; set; } = String.Empty;

        [MaxLength(64)]
        public string FirstName { get; set; } = String.Empty;

        [MaxLength(64)]
        public string LastName { get; set; } = String.Empty;
    }
}
