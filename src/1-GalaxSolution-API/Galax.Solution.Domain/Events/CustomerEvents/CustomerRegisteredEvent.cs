namespace Galax.Solution.Domain.Events.CustomerEvents
{
<<<<<<< HEAD
    public class CustomerRegisteredEvent : Event
    {
        ublic CustomerRegisteredEvent(Guid id, string name) 
        {
            Id = id;
            Name = name;
            AggregateId = id;

        }
        public Guid Id { get; set; }
        public string Name{ get; private set; }

        
=======
    public class CustomerRegisteredEvent
    {
>>>>>>> Development2
        
    }
}