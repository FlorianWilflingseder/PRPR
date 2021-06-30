using EventManager.Contracts;
using EventManager.Contracts.Client;
using EventManager.Contracts.Persistence.EventManager;
using EventManager.Logic.Contracts;

namespace EventManager.Logic
{
    partial class Factory
    {
        static partial void CreateController<C>(IContext context, ref IControllerAccess<C> controller)
            where C : IIdentifiable
        {
            if (typeof(C) == typeof(IEvent))
            {
                controller = new Controllers.Persistence.EventManager.EventController(context) as IControllerAccess<C>;
            }
        }

        static partial void CreateController<C>(Controllers.ControllerObject controllerObject, ref IControllerAccess<C> controller)
            where C : IIdentifiable
        {
            if (typeof(C) == typeof(IEvent))
            {
                controller = new Controllers.Persistence.EventManager.EventController(controllerObject) as IControllerAccess<C>;
            }
        }
    }
}
