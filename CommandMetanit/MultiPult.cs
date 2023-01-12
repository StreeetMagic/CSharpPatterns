using System.Collections.Generic;

namespace CommandMetanit
{
    internal class MultiPult
    {
        private readonly ICommand[] _buttons;
        private readonly Stack<ICommand> _commandsHistory;

        public MultiPult()
        {
            _buttons = new ICommand[2];

            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[i] = new NoCommand();
            }
            _commandsHistory = new Stack<ICommand>();
        }

        public void SetCommand(int number, ICommand com)
        {
            _buttons[number] = com;
        }

        public void PressButton(int number)
        {
            _buttons[number].Execute();
            _commandsHistory.Push(_buttons[number]);
        }

        public void PressUndoButton()
        {
            if (_commandsHistory.Count > 0)
            {
                ICommand undoCommand = _commandsHistory.Pop();
                undoCommand.Undo();
            }
        }
    }
}