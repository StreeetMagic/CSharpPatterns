using System;

namespace TemplateMethod
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            School school = new School();
            University university = new University();
 
            school.Learn();
            university.Learn();
 
            Console.Read();
        }
    }
}