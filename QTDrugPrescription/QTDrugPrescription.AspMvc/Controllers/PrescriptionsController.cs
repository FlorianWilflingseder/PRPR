using Microsoft.AspNetCore.Mvc;
using QTDrugPrescription.Logic.Controllers;
using QTDrugPrescription.Logic.Entities;

namespace QTDrugPrescription.AspMvc.Controllers
{
    public class PrescriptionsController : GenericController<Logic.Entities.Prescription, Models.Prescription>
    {
        public PrescriptionsController(Logic.Controllers.PrescriptionController controller) : base(controller)
        {
        }
    }
}
