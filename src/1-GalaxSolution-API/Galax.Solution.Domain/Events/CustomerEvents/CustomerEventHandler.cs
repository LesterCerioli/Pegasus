namespace Galax.Solution.Domain.Events.CustomerEvents
{
<<<<<<< HEAD
    public class CustomerEventHandler :
        INotificationHandler<CustomerRegisteredEvent>,
        INotificationHandler<CustomerUpdatedEvent>,
        INotificationHandler<CustomerRemovedEvent>

    {
        public Task Handle(CustomerRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CustomerUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(CustomerRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
=======
    public class CustomerEventHandler
    {
>>>>>>> Development2
        
    }
}