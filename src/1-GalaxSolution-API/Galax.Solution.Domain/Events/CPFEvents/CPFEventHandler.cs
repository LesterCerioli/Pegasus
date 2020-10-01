using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.CPFEvents
{
    public class CPFEventHandler :
        INotificationHandler<CPFRegisteredEvent>,
        INotificationHandler<CPFUpdatedEvent>,
        INotificationHandler<CPFRemovedEvent>
    {
        public Task Handle(CPFRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CPFUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CPFRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
