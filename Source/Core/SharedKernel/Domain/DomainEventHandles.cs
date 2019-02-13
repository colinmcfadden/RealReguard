namespace Core.SharedKernel.Domain
{
    public class DomainEventHandles<TDomainEvent> : Handles<TDomainEvent>
        where TDomainEvent : DomainEvent
    {
        public void Handle(TDomainEvent args)
        {
            throw new System.NotImplementedException();
        }
    }
}