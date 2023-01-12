using System;
using System.Windows.Input;

namespace CommandMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Tv tv = new Tv();
            Volume volume = new Volume();
            MultiPult multiPult = new MultiPult();
            multiPult.SetCommand(0, new TvOnCommand(tv));
            multiPult.SetCommand(1, new VolumeCommand(volume));
            multiPult.PressButton(0);
            multiPult.PressButton(1);
            multiPult.PressButton(1);
            multiPult.PressButton(1);
            multiPult.PressUndoButton();
            multiPult.PressUndoButton();
            multiPult.PressUndoButton();
            multiPult.PressUndoButton();

            Console.Read();
        }
    }
}