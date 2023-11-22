namespace ServiceLocatorSyndicate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class ServiceLocator
    {
        private static ServiceLocator _instance;

        public static ServiceLocator Instance => _instance ??= new ServiceLocator();

        public TService RegisterSingle<TService>(TService implementation) where TService : IService
        {
            return Implementation<TService>.ServiceInstance = implementation;
        }

        public TService Single<TService>() where TService : IService
        {
            return Implementation<TService>.ServiceInstance;
        }

        private class Implementation<TService> where TService : IService
        {
            public static TService ServiceInstance;
        }

        public interface IService
        {
        }
    }
}