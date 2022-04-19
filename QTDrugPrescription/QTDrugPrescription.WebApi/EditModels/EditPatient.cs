using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.WebApi.EditModels
{
    public class EditPatient
    {
        public DateTime Birthday { get; set; } 
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string SocialSecurityNumber { get; set; } = string.Empty;
    }
}
