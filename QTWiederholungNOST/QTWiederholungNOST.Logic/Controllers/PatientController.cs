using QTWiederholungNOST.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTWiederholungNOST.Logic.Controllers
{
    public class PatientController : GenericController<Patient>
    {
        public PatientController()
        {

        }

        public PatientController(ControllerObject other) : base(other)
        {

        }


        public override Task<Patient> InsertAsync(Patient entity)
        {
            CheckEntity(entity);
            return base.InsertAsync(entity);
        }

        public override Task<Patient> UpdateAsync(Patient entity)
        {
            CheckEntity(entity);
            return base.UpdateAsync(entity);
        }

        public void CheckEntity(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentNullException(nameof(patient));
            }
            if (patient.FirstName.Length < 3)
            {
                throw new Modules.Exceptions.LogicException($"FirstName zu kurz");
            }
            if(patient.LastName.Length < 3)
            {
                throw new Modules.Exceptions.LogicException($"LastName ist zu kurz");
            }
            if (!CheckSSN(patient.SocialSecurityNumber))
            {
                throw new Modules.Exceptions.LogicException($"SSN ungültig");
            }
           
        }



        public bool CheckSSN(string ssn)
        {
            int[] weighting = { 3, 7, 9, 5, 8, 4, 2, 1, 6 };
            int counter = 0;
            var result = 0;
            int rest = 0;
            bool isValid = false;
            for (int i = 0; i < weighting.Length; i++)
            {
                if (i == 3)
                {
                    counter++;
                }
                result += (ssn[counter] - '0') * weighting[i];
                counter++;
            }
            rest = result % 11;

            if (rest == (ssn[3] - '0') && rest != 10)
            {
                isValid = true;
            }
            return isValid;
        }


    }
}
