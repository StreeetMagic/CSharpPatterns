namespace MediatorMetanit
{
    internal abstract class Colleague
    {
        private readonly Mediator _mediator;

        protected Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
 
        public void Send(string message)
        {
            _mediator.Send(message, this);
        }
        
        public abstract void Notify(string message);
    }
}