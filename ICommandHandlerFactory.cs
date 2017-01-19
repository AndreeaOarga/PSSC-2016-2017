using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.CQRS.CommandHandlers;
using Models.CQRS.Commands;

namespace Models.CQRS.Utils
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}
