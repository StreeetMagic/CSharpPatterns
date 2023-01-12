using FactoryMethodMetanit.Houses;

namespace FactoryMethodMetanit.Developers
{
    internal abstract class Developer
    {
        protected Developer (string n)
        {
        }

        public abstract House Create();
    }
}