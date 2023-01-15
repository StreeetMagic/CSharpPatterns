namespace SingletonMetanit
{
    internal class OperatingSystem
    {
        private static OperatingSystem _instance;

        public string Name { get; }

        private OperatingSystem(string name)
        {
            Name = name;
        }

        public static OperatingSystem GetInstance(string name)
        {
            if (_instance == null)
                _instance = new OperatingSystem(name);

            return _instance;
        }
    }
}