using QTDrugNost.Logic.Controllers;
using QTDrugNost.Logic.Entities;

namespace QTDrugNost.AspMvc.Controllers
{
    public class PatientController : GenericController<Patient, Models.Patient>
    {
        public PatientController(Logic.Controllers.PatientsController controller) : base(controller)
        {

        }
    }
}
