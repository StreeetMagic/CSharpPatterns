using System;

namespace TemplateMethod
{
    internal abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }

        protected abstract void Enter();

        protected abstract void Study();

        protected virtual void PassExams()
        {
            Console.WriteLine("Сдаем выпускные экзамены");
        }

        protected abstract void GetDocument();
    }
}