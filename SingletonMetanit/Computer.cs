namespace SingletonMetanit
{
    internal class Computer
    {
        public OperatingSystem OperatingSystem { get; set; }

        public void Launch(string osName)
        {
            OperatingSystem = OperatingSystem.GetInstance(osName);
        }
    }
}