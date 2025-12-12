using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public abstract class Entity
    {
        private readonly List<IDomainEvents> _domainEvents = new();
        protected Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; init; }

        public IReadOnlyList<IDomainEvents> GetDomainEvents()
        {
            return _domainEvents.ToList();
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        protected void RaiseDomainEvent(IDomainEvents domainEvents)
        {
            _domainEvents.Add(domainEvents);
        }
    }
}
