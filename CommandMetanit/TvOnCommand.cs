namespace CommandMetanit
{
    internal class TvOnCommand : ICommand
    {
        private readonly Tv _tv;

        public TvOnCommand(Tv tvSet)
        {
            _tv = tvSet;
        }

        public void Execute()
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}