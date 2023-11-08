using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppzv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2, b = 4, c = 6, d = 8, 
                x = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)) / (Math.Pow((a + b), 2) + Math.Pow((c + d), 2));

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
