using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    internal class ex
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Int16.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr["+i+"] = ");
                arr[i] = Int16.Parse(Console.ReadLine());
            }
            int max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= max)
                    max = arr[i];
            }
            Console.WriteLine("So lon nhat trong mang la: "+max);
        }
    }
}
