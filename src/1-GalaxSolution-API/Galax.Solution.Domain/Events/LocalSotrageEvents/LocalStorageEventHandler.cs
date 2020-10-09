using Galax.Solution.Domain.Events.LocalStorageEvents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.LocalStorageEvents
{
    public class LocalStorageEventHandler :
        INotificationHandler<LocalStorageRegisteredEvent>,
        INotificationHandler<LocalStorageUpdatedEvent>,
        INotificationHandler<LocalStorageRemovedEvent>



    {
        public Task Handle(LocalStorageRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(LocalStorageUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(LocalStorageRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
