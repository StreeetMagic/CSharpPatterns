using System;

namespace CompositeMetanit
{
    internal static class Program
    {
        private static void Main()
        {
            Component fileSystem = new Directory("Файловая система");
            Component diskC = new Directory("Диск С");
            
            Component pngFile = new File("12345.png");
            Component docxFile = new File("Document.docx");
            
            diskC.Add(pngFile);
            diskC.Add(docxFile);
            
            fileSystem.Add(diskC);
            fileSystem.Print();
            
            Console.WriteLine();
            diskC.Remove(pngFile);
            Component docsFolder = new Directory("Мои Документы");
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);
            fileSystem.Print();
            Console.Read();
        }
    }
}

// https://metanit.com/sharp/patterns/4.4.php