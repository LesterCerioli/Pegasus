using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.InventarioEstoqueEvents
{
    public class InventarioEstoqueEventHandler :
        INotificationHandler<InventarioEstoqueRegisteredEvent>,
        INotificationHandler<InventarioEstoqueRemovedEvent>,
        INotificationHandler<InventarioEstoqueUpdatedEvent>


    {
        public Task Handle(InventarioEstoqueRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(InventarioEstoqueRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(InventarioEstoqueUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
