using System;

namespace Models.CQRS.Commands
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}
