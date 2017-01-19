using System;

namespace Models.CQRS.Events
{
    [Serializable]
    public class Event:IEvent
    {
        public int Version;
        public Guid AggregateId { get; set; }
        public Guid Id { get; private set; }
    }
}
