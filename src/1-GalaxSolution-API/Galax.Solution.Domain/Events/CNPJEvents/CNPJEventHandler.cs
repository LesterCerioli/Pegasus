using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.CNPJEvents
{
    public class CNPJEventHandler :
        INotificationHandler<CNPJRegisteredEvent>,
        INotificationHandler<CNPJUpdatedEvent>,
        INotificationHandler<CNPJRemovedEvent>
    {
        public Task Handle(CNPJRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CNPJUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;

        }

        public Task Handle(CNPJRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;

        }
    }
}
