using System;
using CommonBase.Attributes;

namespace EventManager.Contracts.Persistence.EventManager
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IEvent : IVersionable, ICopyable<IEvent>
    {
        [ContractPropertyInfo(Required = true)]
        public DateTime StartingAt { get; set; }

        [ContractPropertyInfo(Required = true)]
        public DateTime EndingAt { get; set; }

        [ContractPropertyInfo(Required = true, MaxLength = 256, IsUnique = true)]
        public string Name { get; set; }

        [ContractPropertyInfo(Required = true, MaxLength = 128)]
        public string Description { get; set; }
    }
}
