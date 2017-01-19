using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsCQRS.Events;

namespace ModelsCQRS.Storage
{
    public interface IEventPublisher
    {
        void Publish(Event @event);
    }
}
