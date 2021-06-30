using EventManager.Contracts.Persistence.EventManager;
using EventManager.Logic.Contracts;
using EventManager.Logic.Entities.EventManager;
using EventManager.Logic.Controllers.Persistence.Business;
using System;

namespace EventManager.Logic.Controllers.Persistence.EventManager
{
    class EventController : GenericPersistenceController<IEvent, Event>
    {
        public EventController(IContext context) : base(context)
        {

        }
        public EventController(ControllerObject controllerObject) : base(controllerObject)
        {

        }

        protected override Event BeforeInsert(Event entity)
        {
            bool safe = BusinessLogic.VerifyName(entity.Name);
            if (!safe)
            {
                throw new ArgumentException();
            }
            return entity;
        }
        protected override Event BeforeUpdate(Event entity)
        {
            bool safe = BusinessLogic.VerifyName(entity.Name);
            if (!safe)
            {
                throw new ArgumentException();
            }
            return entity;
        }
        
    }
}
