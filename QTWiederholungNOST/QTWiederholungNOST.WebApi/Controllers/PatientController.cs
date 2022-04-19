using QTWiederholungNOST.Logic.Controllers;
using QTWiederholungNOST.Logic.Entities;

namespace QTWiederholungNOST.WebApi.Controllers
{
    public class PatientController : GenericController<Logic.Entities.Patient, Models.PatientEdit, Models.Patient>
    {
        public PatientController(GenericController<Patient> controller) : base(controller)
        {
        }
    }
}
