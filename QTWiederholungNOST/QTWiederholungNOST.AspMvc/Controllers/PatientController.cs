using QTWiederholungNOST.Logic.Controllers;
using QTWiederholungNOST.Logic.Entities;

namespace QTWiederholungNOST.AspMvc.Controllers
{
    public class PatientController : GenericController<Logic.Entities.Patient, Models.Patient>
    {
        public PatientController(Logic.Controllers.PatientController controller) : base(controller)
        {
        }
    }
}
