using System;

namespace MopFW
{
    public static  class FW
    {
        public static void CountMopsFramework()
        {
            Console.WriteLine($"Hi");
            using (var context = new MopFW.MopContextFW())
            {
                var num = context.Mops.Count();
                Console.WriteLine($"There are {num} mops \r\n in {context.Database.Connection.ConnectionString}");
            }
            Console.ReadKey();
        }
    }
}