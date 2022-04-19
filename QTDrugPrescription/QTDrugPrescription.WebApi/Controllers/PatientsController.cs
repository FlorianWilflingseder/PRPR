using Microsoft.AspNetCore.Mvc;

namespace QTDrugPrescription.WebApi.Controllers
{
    public class PatientsController : GenericController<Logic.Entities.Patient, EditModels.EditPatient, Models.Patient>
    {
        public PatientsController(Logic.Controllers.PatientController controller) : base(controller)
        {
        }
    }
}
