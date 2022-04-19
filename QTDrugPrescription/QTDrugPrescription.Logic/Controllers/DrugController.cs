using QTDrugPrescription.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Controllers
{
    public sealed partial class DrugController : GenericController<QTDrugPrescription.Logic.Entities.Drug>
    {
        public DrugController() : base()
        {
        }

        public DrugController(ControllerObject other) : base(other)
        {
        }

        public override Task<Drug> InsertAsync(Drug entity)
        {
            var isMedicNumber = CheckMedicationNumber(entity.Number);
            if (isMedicNumber == false)
            {
                throw new Logic.Modules.Exceptions.LogicException($"Invalid MedNumber {entity.Number}");
            }
            return base.InsertAsync(entity);
        }

        public override Task<IEnumerable<Drug>> InsertAsync(IEnumerable<Drug> entities)
        {
            entities.ToList().ForEach(e =>
            {
                if(!CheckMedicationNumber(e.Number))
                    throw new Logic.Modules.Exceptions.LogicException($"Invalid MedNumber{e.Number}");
            });
            return base.InsertAsync(entities);
        }

        public override Task<Drug> UpdateAsync(Drug entity)
        {
            var isMedicNumber = CheckMedicationNumber(entity.Number);
            if (isMedicNumber == false)
            {
                throw new Logic.Modules.Exceptions.LogicException($"Invalid MedNumber {entity.Number}");
            }
            return base.UpdateAsync(entity);
        }

        public override Task<IEnumerable<Drug>> UpdateAsync(IEnumerable<Drug> entities)
        {
            entities.ToList().ForEach(e =>
            {
                if (!CheckMedicationNumber(e.Number))
                    throw new Logic.Modules.Exceptions.LogicException($"Invalid MedNumber{e.Number}");
            });
            return base.UpdateAsync(entities);
        }

        public bool CheckMedicationNumber(string MedNum)
        {
            bool isValid = false;
            var result = 0;
            char rest;
            if (MedNum == null)
            {
                isValid = false;
            }
            else
            {
                for (int i = 0; i <= 8; i++)
                {
                    result += (MedNum[i] - '0') * (i + 1);
                }

                result = result % 11;

                if (result == 10)
                {
                    rest = 'X';
                }
                else
                {
                    rest = (char)result;
                }

                if (rest == MedNum[9])
                {
                    isValid = true;
                }
                else { isValid = false; }

            }

            return isValid;
        }


    }
}
