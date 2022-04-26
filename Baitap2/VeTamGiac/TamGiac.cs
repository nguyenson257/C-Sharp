using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeTamGiac
{
    internal class TamGiac
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Nhap chieu cao tam giac: h = ");
            n = Int16.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");

                for (j = 1; j <= i; j++)
                    if (j == 1 || j == i||i==n)
                        Console.Write("* ");
                    else
                        Console.Write("  ");

                Console.WriteLine();
            }

        }
    }
}
