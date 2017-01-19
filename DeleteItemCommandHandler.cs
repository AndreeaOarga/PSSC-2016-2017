using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.CQRS.Commands;
using Models.CQRS.Domain;
using Models.CQRS.Storage;

namespace Models.CQRS.CommandHandlers
{
    public class DeleteItemCommandHandler : ICommandHandler<DeleteItemCommand>
    {
        private readonly IRepository<ModelsItem> _repository;

        public DeleteItemCommandHandler(IRepository<ModelsItem> repository)
        {
            _repository = repository;
        }

        public void Execute(DeleteItemCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }

            var aggregate = _repository.GetById(command.Id);
            aggregate.Delete();
            _repository.Save(aggregate,aggregate.Version);
            
        }
    }
}
