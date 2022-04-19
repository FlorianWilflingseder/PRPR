using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.WebApi.Models
{
    public class Prescription : VersionModel
    {
        
        public int PatientId { get; set; }

        
        public int DrugId { get; set; }

        public DateTime Date { get; set; }

        string Dosing { get; set; } = string.Empty;
    }
}
