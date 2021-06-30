using System;
using CommonBase.Extensions;
using EventManager.Contracts.Persistence.EventManager;

namespace EventManager.Logic.Entities.EventManager
{
    partial class Event : VersionEntity, IEvent
    {
        public DateTime StartingAt { get; set; }
        public DateTime EndingAt { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void CopyProperties(IEvent other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            RowVersion = other.RowVersion;
            StartingAt = other.StartingAt;
            EndingAt = other.EndingAt;
            Name = other.Name;
            Description = other.Description;
        }
    }
}
