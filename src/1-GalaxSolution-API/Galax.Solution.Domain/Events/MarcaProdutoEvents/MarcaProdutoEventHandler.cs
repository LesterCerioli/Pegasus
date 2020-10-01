using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.MarcaProdutoEvents
{
    public class MarcaProdutoEventHandler :
        INotificationHandler<MarcaProdutoRegisteredEvent>,
        INotificationHandler<MarcaProdutoUpdatedEvent>,
        INotificationHandler<MarcaProdutoRemovedEvent>
    {
        public Task Handle(MarcaProdutoRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(MarcaProdutoUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(MarcaProdutoRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
