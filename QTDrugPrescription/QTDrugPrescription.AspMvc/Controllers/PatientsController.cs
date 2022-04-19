using Microsoft.AspNetCore.Mvc;
using QTDrugPrescription.Logic.Controllers;
using QTDrugPrescription.Logic.Entities;

namespace QTDrugPrescription.AspMvc.Controllers
{
    public class PatientsController : GenericController<Logic.Entities.Patient, Models.Patient>
    {
        public PatientsController(Logic.Controllers.PatientController controller) : base(controller)
        {
        }
    }
}
