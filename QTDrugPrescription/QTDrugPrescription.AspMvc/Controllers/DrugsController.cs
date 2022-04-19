using Microsoft.AspNetCore.Mvc;
using QTDrugPrescription.Logic.Controllers;
using QTDrugPrescription.Logic.Entities;

namespace QTDrugPrescription.AspMvc.Controllers
{
    public class DrugsController : GenericController<Logic.Entities.Drug, Models.Drug>
    {
        public DrugsController(Logic.Controllers.DrugController controller) : base(controller)
        {
        }
    }
}
