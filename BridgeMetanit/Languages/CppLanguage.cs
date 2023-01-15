using System;

namespace BridgeMetanit
{
    internal class CppLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("С помощью компилятора C++ компилируем программу в бинарный код");
        }
 
        public void Execute()
        {
            Console.WriteLine("Запускаем исполняемый файл программы");
        }
    }
}