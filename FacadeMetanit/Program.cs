using System;

namespace FacadeMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();
         
            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);
         
            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);
         
            Console.Read();
        }
    }
}