using QTDrugStore.Logic.Controllers;
using QTDrugStore.Logic.Entities;

namespace QTDrugStore.WebApi.Controllers
{
    public class PatientController : GenericController<Logic.Entities.Patient, Models.PatientEdit, Models.Patient>
    {
        public PatientController(Logic.Controllers.PatientController controller) : base(controller)
        {
        }
    }
}
