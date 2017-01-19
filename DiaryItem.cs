using System;
using Models.CQRS.Domain.Mementos;
using Models.CQRS.Events;
using Models.CQRS.Storage.Memento;

namespace Models.CQRS.Domain
{
    public class ModelsItem : AggregateRoot, 
        IHandle<ItemCreatedEvent>,
        IHandle<ItemRenamedEvent>,
        IHandle<ItemFromChangedEvent>, 
        IHandle<ItemToChangedEvent>,
        IHandle<ItemDescriptionChangedEvent>,
        IOriginator
    {
        public string Title { get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Description { get; set; }

        public ModelsItem()
        {
            
        }

        public ModelsItem(Guid id,string title, string description,  DateTime from, DateTime to)
        {
            ApplyChange(new ItemCreatedEvent(id, title,description, from, to));
        }

        public void ChangeTitle(string title)
        {
            ApplyChange(new ItemRenamedEvent(Id, title));
        }

        public void ChangeDescription(string description)
        {
            ApplyChange(new ItemDescriptionChangedEvent(Id, description));
        }

        public void ChangeFrom(DateTime from)
        {
            ApplyChange(new ItemFromChangedEvent(Id, from));
        }

        public void ChangeTo(DateTime to)
        {
            ApplyChange(new ItemToChangedEvent(Id, to));
        }

        public void Delete()
        {
            ApplyChange(new ItemDeletedEvent(Id));
        }

        public void Handle(ItemDeletedEvent e)
        {
            
        }

        public void Handle(ItemCreatedEvent e)
        {
            Title = e.Title;
            From = e.From;
            To = e.To;
            Id = e.AggregateId;
            Description = e.Description;
            Version = e.Version;
        }

        public void Handle(ItemRenamedEvent e)
        {
            Title = e.Title;
        }

        public void Handle(ItemFromChangedEvent e)
        {
            From = e.From;
        }

        public void Handle(ItemToChangedEvent e)
        {
            To = e.To;
        }

        public void Handle(ItemDescriptionChangedEvent e)
        {
            Description = e.Description;
        }
     
        public BaseMemento GetMemento()
        {
            return new ModelsItemMemento(Id,Title, Description,From,To,Version);
        }

        public void SetMemento(BaseMemento memento)
        {
            Title = ((ModelsItemMemento) memento).Title;
            To = ((ModelsItemMemento)memento).To;
            Version= memento.Version;
            From = ((ModelsItemMemento)memento).From;
            Description = ((ModelsItemMemento)memento).Description;
            Id = memento.Id;
        }

        
    }
}
