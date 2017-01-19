using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.CommandHandler
{
    class ChangeTaskStatusCommandHandler
    {
    }
}: ICommandHandler<ChangeTaskStatusCommand>
    {
        private readonly IRepository<Task> _taskRepository;

        public ChangeTaskStatusCommandHandler(IRepository<Task> taskRepository)
        {
            if (taskRepository == null) { throw new ArgumentNullException("taskRepository"); }
            _taskRepository = taskRepository;
        }

        public void Execute(ChangeTaskStatusCommand command)
        {
            if (command == null) { throw new ArgumentNullException("command"); }
            if (string.IsNullOrWhiteSpace(command.TaskId)) { throw new ArgumentException("Id is not specified", "command"); }

            var task = _taskRepository.All().Single(x => x.Id == command.TaskId);
            task.IsCompleted = command.IsCompleted;
            task.LastUpdated = command.UpdatedOn;

            _taskRepository.Update(task);
        }

    }
}
