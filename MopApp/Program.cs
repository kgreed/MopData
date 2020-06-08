using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MopData;
namespace MopApp
{
    class Program
    {
        static void Main(string[] args)
        {

            CountMops();
        }

        private static void CountMops()
        {
            using (var context = new MopContext())
            {
                var num = context.Mops.Count();
                Console.WriteLine($"There are {num} mops");
            }
        }
    }
}
