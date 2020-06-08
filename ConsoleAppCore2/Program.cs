using System;
using System.Linq;
using MopCore;
using MopFW;
namespace ConsoleAppCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CountMopsCore();
            FW.CountMopsFramework();
        }

        private static void CountMopsCore()
        {
            Console.WriteLine($"Hi");
            using (var context = new MopContext())
            {
                var num = context.Mops.Count();
                Console.WriteLine($"There are {num} mops \r\n providern {context.Database.ProviderName}");
            }
            Console.ReadKey();
        }

       
    }
}