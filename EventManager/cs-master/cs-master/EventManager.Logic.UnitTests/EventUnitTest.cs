using EventManager.Contracts.Persistence.EventManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using EventManager.Logic.Entities.EventManager;

namespace EventManager.Logic.UnitTests
{
    [TestClass]
    public class EventUnitTest
    {
        private static EventManager.Contracts.Client.IControllerAccess<IEvent> CreateController() {
            return Logic.Factory.Create<IEvent>();
        }
        private static async void DeleteAllEventsAsync()
        {
            using var ctrl = CreateController();
            foreach(var item in await ctrl.GetAllAsync())
            {
                await ctrl.DeleteAsync(item.Id);
            }
            await ctrl.SaveChangesAsync();
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext Conetext)
        {
            DeleteAllEventsAsync();
            
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            DeleteAllEventsAsync();
        }


        [TestInitialize]
        public void TestInitialize()
        {

        }

        [TestCleanup]
        public void TestCleanup()
        {
           
        }

        [TestMethod]
        public void Create_NoneRequirements_Result()
        {
            Task.Run(async () =>
            {
                using var ctrl = CreateController();
                var entity = await ctrl.CreateAsync();
                Assert.IsNotNull(entity);


            }).Wait();
        }

        [TestMethod]
        [ExpectedException(typeof(AggregateException))]
        public void Insert_WithUniqueName_ResultPersistenceEntity()
        {
            Task.Run(async () =>
            {
                using var ctrl = CreateController();
                var entity = await ctrl.CreateAsync();


                entity.Name = "Event1233";
                var expected = await ctrl.InsertAsync(entity);

                await ctrl.SaveChangesAsync();
                


            }).Wait();
        }

        [TestMethod]
        public void VerifyName_IncorrectName_False()
        {
            Assert.IsFalse(Logic.Controllers.Persistence.Business.BusinessLogic.VerifyName("Egga23123"));
            


        }
        [TestMethod]
        public void VerifyName_CorrectName_True()
        {
            Assert.IsTrue(Logic.Controllers.Persistence.Business.BusinessLogic.VerifyName("Egga"));



        }

    }
}
