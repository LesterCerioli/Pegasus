using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.CityEvent
{
    public class CityEventHandler :
        INotificationHandler<CityRegisteredEvent>,
        INotificationHandler<CityUpdatedEvent>,
        INotificationHandler<CityRemovedEvent>
    {
        public Task Handle(CityRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CityUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CityRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
