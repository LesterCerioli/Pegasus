using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.UnidadeMedidaEvents
{
    public class UnidadeMedidaEventHandler :
        INotificationHandler<UnidadeMedidaRegisteredEvent>,
        INotificationHandler<UnidadeMedidaUpdatedEvent>,
        INotificationHandler<UnidadeMedidaRemovedEvent>
    {
        public Task Handle(UnidadeMedidaRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(UnidadeMedidaUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(UnidadeMedidaRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
