using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.FornecedorEvents
{
    public class FornecedorEventHandler :
        INotificationHandler<FornecedorRegisteredEvent>,
        INotificationHandler<FornecedorUpdatedEvent>,
        INotificationHandler<FornecedorRemovedEvent>
    {
        public Task Handle(FornecedorRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(FornecedorUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(FornecedorRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
