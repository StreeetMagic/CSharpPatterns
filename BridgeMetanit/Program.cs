using System;

namespace BridgeMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Programmer freelancer = new FreelanceProgrammer(new CppLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
            freelancer.SetLanguage(new CSharpLanguage()); 
            freelancer.DoWork();
            freelancer.EarnMoney();
 
            Console.Read();
        }
    }
}