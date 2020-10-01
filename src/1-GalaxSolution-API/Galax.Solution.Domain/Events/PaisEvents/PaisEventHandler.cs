using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.PaisEvents
{
    public class PaisEventHandler :
        INotificationHandler<PaisRegisteredEvent>,
        INotificationHandler<PaisUpdatedEvent>,
        INotificationHandler<PaisRemovedEvent>
    {
        public Task Handle(PaisRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PaisUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PaisRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
