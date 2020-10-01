using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.EstadoEvents
{
    public class EstadoEventHandler :
        INotificationHandler<EstadoRegisteredEvent>,
        INotificationHandler<EstadoUpdatedEvent>,
        INotificationHandler<EstadoRemovedEvent>
    {
        public Task Handle(EstadoRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(EstadoUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(EstadoRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
