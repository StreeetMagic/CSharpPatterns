namespace CommandMetanit
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}