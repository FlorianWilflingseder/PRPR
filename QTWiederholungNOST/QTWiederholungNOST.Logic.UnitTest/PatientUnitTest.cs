using Microsoft.VisualStudio.TestTools.UnitTesting;
using QTWiederholungNOST.Logic.Controllers;
using QTWiederholungNOST.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTWiederholungNOST.Logic.UnitTest
{
    [TestClass]
    public class PatientUnitTest : EntityUnitTest<Patient>
    {
        public override GenericController<Patient> CreateController()
        {
            return new PatientController();

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

            patient.FirstName = "FLocki";
            patient.LastName = "Wilfiof";
            patient.SocialSecurityNumber = "3285171076";

            Patient insertedPatient = await ctrl.InsertAsync(patient);

            Assert.IsTrue(insertedPatient.AreEqualProperties(patient));

        }

        [TestMethod]
        [ExpectedException(typeof(Modules.Exceptions.LogicException))]
        public async Task CreatePatient_WithInValidSSN_ShouldNotCreate()
        {
            using var ctrl = CreateController();
            Patient patient = new Patient();

            patient.FirstName = "FLocki";
            patient.LastName = "Wilfiof";
            patient.SocialSecurityNumber = "3285100076";

            Patient insertedPatient = await ctrl.InsertAsync(patient);
        }
    }
}
