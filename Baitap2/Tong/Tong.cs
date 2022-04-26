using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tong
{
    internal class Tong
    {
        static void Main(string[] args)
        {
            int n,s=0;
            Console.WriteLine("Nhap n = ");
            n = Int16.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                s = s + i;
            Console.WriteLine("S = "+s);

        }
    }
}
