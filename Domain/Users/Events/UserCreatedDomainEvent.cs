using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users.Events
{
    public record UserCreatedDomainEvent(Guid UserId):IDomainEvents
    {
    }
}
