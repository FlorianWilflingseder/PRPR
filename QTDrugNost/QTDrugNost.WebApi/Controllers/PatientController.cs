using QTDrugNost.Logic.Controllers;
using QTDrugNost.Logic.Entities;

namespace QTDrugNost.WebApi.Controllers
{
    public class PatientController : GenericController<Logic.Entities.Patient, Models.PatientEdit, Models.Patient>
    {
        public PatientController(GenericController<Patient> controller) : base(controller)
        {
        }
    }
}
