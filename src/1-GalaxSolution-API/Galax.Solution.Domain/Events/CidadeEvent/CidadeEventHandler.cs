using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.CidadeEvent
{
    public class CidadeEventHandler :
        INotificationHandler<CidadeRegisteredEvent>,
        INotificationHandler<CidadeUpdatedEvent>,
        INotificationHandler<CidadeRemovedEvent>
    {
        public Task Handle(CidadeRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CidadeUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CidadeRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
