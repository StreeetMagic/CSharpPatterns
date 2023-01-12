namespace CommandMetanit
{
    internal class VolumeCommand : ICommand
    {
        private readonly Volume _volume;

        public VolumeCommand(Volume v)
        {
            _volume = v;
        }

        public void Execute()
        {
            _volume.RaiseLevel();
        }

        public void Undo()
        {
            _volume.DropLevel();
        }
    }
}