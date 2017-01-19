using System;
using Models.CQRS.Commands;

namespace Models.CQRS.Messaging
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}
