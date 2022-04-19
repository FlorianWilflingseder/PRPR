using Microsoft.AspNetCore.Mvc;
using QTDrugPrescription.Logic.Controllers;
using QTDrugPrescription.Logic.Entities;
using QTDrugPrescription.WebApi.Controllers;

namespace QTDrugPrescription.WebApi.Controllers
{
    public class DrugsController : GenericController<Logic.Entities.Drug,EditModels.EditDrug,Models.Drug>
    {
        public DrugsController(Logic.Controllers.DrugController controller) : base(controller)
        {
        }
    }
}
