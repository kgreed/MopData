using System;
using System.Linq;
namespace MopCore
{
    public class CoreFuncs
    {
        public static void CountMops()
        {
            Console.WriteLine($"Hi from CoreFuncs");
            using (var context = new MopContext())
            {
                var num = context.Mops.Count();
                Console.WriteLine($"There are {num} mops \r\n with provider name {context.Database.ProviderName}");
            }
            Console.ReadKey();
        }
    }
   
}
