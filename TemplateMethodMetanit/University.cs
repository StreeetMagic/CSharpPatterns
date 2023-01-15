using System;

namespace TemplateMethod
{
    internal class University : Education
    {
        protected override void Enter()
        {
            Console.WriteLine("Сдаем вступительные экзамены и поступаем в ВУЗ");
        }

        protected override void Study()
        {
            Console.WriteLine("Посещаем лекции");
            Console.WriteLine("Проходим практику");
        }

        protected override void PassExams()
        {
            Console.WriteLine("Сдаем экзамен по специальности");
        }

        protected override void GetDocument()
        {
            Console.WriteLine("Получаем диплом о высшем образовании");
        }
    }
}