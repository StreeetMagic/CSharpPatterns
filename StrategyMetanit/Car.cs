namespace StategyMetanit
{
    internal class Car : IMovable
    {
        private int _passengers; 
        private string _model; 
        
        public Car(int num, string model, IMovable mov)
        {
            _passengers = num;
            _model = model;
            Movable = mov;
        }
        
        public IMovable Movable { private get; set; }
        
        public void Move()
        {
            Movable.Move();
        }
    }
}