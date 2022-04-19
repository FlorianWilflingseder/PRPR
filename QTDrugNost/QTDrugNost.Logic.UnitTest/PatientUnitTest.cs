using Microsoft.VisualStudio.TestTools.UnitTesting;
using QTDrugNost.Logic.Controllers;
using QTDrugNost.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugNost.Logic.UnitTest
{
    [TestClass]
    public class PatientUnitTest : EntityUnitTest<Patient>
    {
        public override GenericController<Patient> CreateController()
        {
            return new Logic.Controllers.PatientsController();
        }


        [TestInitialize]
        public async Task TestInitialize()
        {
            await DeleteControllerEntities();
        }

        [TestMethod]
        public async Task CreatePatient_WithValidSSN_ShouldCreate()
        {
            using var ctrl = CreateController();
            Patient patient = new Patient();
            patient.FirstName = "Flowilfl";
            patient.LastName = "Wilflf";
            patient.SocialSecurityNumber = "3285171076";

            Patient insertedPatient = await ctrl.InsertAsync(patient);
            Assert.IsTrue(insertedPatient.AreEqualProperties(patient));

        }

        [TestMethod]
        [ExpectedException(typeof(Modules.Exceptions.LogicException))]
        public async Task CreatePatient_WithInvalidSSN_ShouldNotCreate()
        {
            using var ctrl = CreateController();
            Patient patient = new Patient();
            patient.FirstName = "Flo";
            patient.LastName = "Wilflings";
            patient.SocialSecurityNumber = "3285100076";

            Patient insertedPatient = await ctrl.InsertAsync(patient); //Bekomme Fehler zurück

        }

        [TestMethod]
        [ExpectedException(typeof(Modules.Exceptions.LogicException))]
        public async Task CreatePatient_WithInvalidFirstName_ShouldNotCreate()
        {
            using var ctrl = CreateController();
            Patient patient = new Patient();
            patient.FirstName = "F";
            patient.LastName = "Wilfl";
            patient.SocialSecurityNumber = "3285171076";

            Patient insertedPatient = await ctrl.InsertAsync(patient);
        }

    }
}
