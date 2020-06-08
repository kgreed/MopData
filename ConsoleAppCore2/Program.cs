using System;
using System.Linq;
using MopCore;
namespace ConsoleAppCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CountMopsCore();
            CountMopsFramework();
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

        private static void CountMopsFramework()
        {
            Console.WriteLine($"Hi");
            using (var context = new MopFramework.MopContext())
            {
                var num = context.Mops.Count();
                Console.WriteLine($"There are {num} mops \r\n in {context.Database.Connection.ConnectionString}");
            }
            Console.ReadKey();
        }
    }
}
