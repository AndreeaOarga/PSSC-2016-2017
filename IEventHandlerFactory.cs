using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.CQRS.EventHandlers;
using Models.CQRS.Events;

namespace Models.CQRS.Utils
{
    public interface IEventHandlerFactory
    {
        IEnumerable<IEventHandler<T>> GetHandlers<T>() where T : Event;
    }
}
