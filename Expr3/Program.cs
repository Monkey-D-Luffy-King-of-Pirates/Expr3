using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 19 % 12;
            a = a * 30 - ((a - 6) * (a / 6 * 60));
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
