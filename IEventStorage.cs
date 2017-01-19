using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.CQRS.Domain;
using Models.CQRS.Domain.Mementos;
using Models.CQRS.Events;

namespace Models.CQRS.Storage
{
    public interface IEventStorage
    {
        IEnumerable<Event> GetEvents(Guid aggregateId);
        void Save(AggregateRoot aggregate);
        T GetMemento<T>(Guid aggregateId) where T: BaseMemento;
        void SaveMemento(BaseMemento memento);
    }
}
