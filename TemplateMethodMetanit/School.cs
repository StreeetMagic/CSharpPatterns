using System;

namespace TemplateMethod
{
    internal class School : Education
    {
        protected override void Enter()
        {
            Console.WriteLine("Идем в первый класс");
        }

        protected override void Study()
        {
            Console.WriteLine("Посещаем уроки, делаем домашние задания");
        }

        protected override void GetDocument()
        {
            Console.WriteLine("Получаем аттестат о среднем образовании");
        }
    }
}