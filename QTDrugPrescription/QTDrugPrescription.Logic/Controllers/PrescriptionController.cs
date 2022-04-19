using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Controllers
{
    public sealed partial class PrescriptionController : GenericController<QTDrugPrescription.Logic.Entities.Prescription>
    {
        public PrescriptionController() : base()
        {

        }

        public PrescriptionController(ControllerObject other) : base(other)
        {

        }
    }
}
