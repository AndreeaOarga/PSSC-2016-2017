using System;

namespace Models.CQRS.Events
{
    public class ItemDeletedEvent:Event
    {
        public ItemDeletedEvent(Guid aggregateId)
        {
			AggregateId = aggregateId;
        }
    }
}
