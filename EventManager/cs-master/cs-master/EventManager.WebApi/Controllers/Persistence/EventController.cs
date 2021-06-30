using Microsoft.AspNetCore.Mvc;
using EventManager.Contracts.Persistence.EventManager;
using EventManager.Transfer.Models.Persistence.EventManager;

namespace EventManager.WebApi.Controllers.Persistence
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class EventController : GenericController<IEvent, Event>
    {
    }
}
