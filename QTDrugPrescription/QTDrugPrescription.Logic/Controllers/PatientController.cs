using QTDrugPrescription.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Controllers
{
    public sealed partial class PatientController : GenericController<QTDrugPrescription.Logic.Entities.Patient>
    {
    
        public PatientController() : base()
        {
        }

        public PatientController(ControllerObject other) : base(other)
        {
        }

        public override Task<Patient> InsertAsync(Patient entity)
        {
            var isCorrectSocialNumber = CheckSocialSecurityNumber(entity.SocialSecurityNumber);
            if(isCorrectSocialNumber == false)
            {
                throw new Logic.Modules.Exceptions.LogicException($"Invalid Social Number");
            }
            return base.InsertAsync(entity);
        }

        public override Task<IEnumerable<Patient>> InsertAsync(IEnumerable<Patient> entities)
        {
            entities.ToList().ForEach(e =>
            {
                if (!CheckSocialSecurityNumber(e.SocialSecurityNumber))
                    throw new Logic.Modules.Exceptions.LogicException($"Invalid SocialSecurityNumber{e.SocialSecurityNumber}");
            });
            return base.InsertAsync(entities);
        }

        public override Task<Patient> UpdateAsync(Patient entity)
        {
            var isCorrectSocialNumber = CheckSocialSecurityNumber(entity.SocialSecurityNumber);
            if (isCorrectSocialNumber == false)
            {
                throw new Logic.Modules.Exceptions.LogicException($"Invalid Social Number");
            }
            return base.UpdateAsync(entity);
        }

        public override Task<IEnumerable<Patient>> UpdateAsync(IEnumerable<Patient> entities)
        {
            entities.ToList().ForEach(e =>
            {
                if (!CheckSocialSecurityNumber(e.SocialSecurityNumber))
                    throw new Logic.Modules.Exceptions.LogicException($"Invalid SocialSecurityNumber{e.SocialSecurityNumber}");
            });

            return base.UpdateAsync(entities);
        }


        public bool CheckSocialSecurityNumber(string SSN)
        {

            bool isValid = false;
            if(SSN == null)
            {
                isValid = false;
            }
            else
            {
                int[] weighting = { 3, 7, 9, 5, 8, 4, 2, 1, 6 };
                var result = 0;
                for(int i = 0; i<= SSN.Length; i++)
                {
                    if(i == 3)
                    {
                        i++;
                    }
                    result += (SSN[i] - '0') * weighting[i];
                   

                }

                if(result % 11 != 10 && result % 11 == (SSN[3] - '0'))
                {
                    isValid = true;
                }
               
            }
            return isValid;
        }
      

    }
}
