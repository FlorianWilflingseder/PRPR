using Microsoft.AspNetCore.Mvc;

namespace QTDrugPrescription.WebApi.Controllers
{
    public class PrescriptionsController:GenericController<Logic.Entities.Prescription,EditModels.EditPrescription,Models.Prescription>
    {
        public PrescriptionsController(Logic.Controllers.PrescriptionController controller) : base(controller)
        {

        }        
    }
}
