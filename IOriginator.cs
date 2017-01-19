using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.CQRS.Domain.Mementos;

namespace Models.CQRS.Storage.Memento
{
    public interface IOriginator
    {
        BaseMemento GetMemento();
        void SetMemento(BaseMemento memento);
    }
}
