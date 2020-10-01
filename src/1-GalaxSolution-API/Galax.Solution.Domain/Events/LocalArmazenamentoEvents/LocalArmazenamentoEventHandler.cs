using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.LocalArmazenamentoEvents
{
    public class LocalArmazenamentoEventHandler :
        INotificationHandler<LocalArmazenamentoRegisteredEvent>,
        INotificationHandler<LocalArmazenamentoUpdatedEvent>,
        INotificationHandler<LocalArmazenamentoRemovedEvent>



    {
        public Task Handle(LocalArmazenamentoRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(LocalArmazenamentoUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(LocalArmazenamentoRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
