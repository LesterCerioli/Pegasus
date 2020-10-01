using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.PerfilEvents
{
    public class PerfilEventHandler :
        INotificationHandler<PerfilRegisteredEvent>,
        INotificationHandler<PerfilUpdatedEvent>,
        INotificationHandler<PerfilRemovedEvent>
    {
        public Task Handle(PerfilRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PerfilUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PerfilRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
