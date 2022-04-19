using QTDrugStore.Logic.Controllers;
using QTDrugStore.Logic.Entities;

namespace QTDrugStore.AspMvc.Controllers
{
    public class PatientController : GenericController<Logic.Entities.Patient, Models.Patient>
    {
        public PatientController(Logic.Controllers.PatientController controller) : base(controller)
        {
        }
    }
}
