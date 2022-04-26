using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_61
{
    internal class TongMang
    {
        static void Main(string[] args)
        {
            int p,S = 0;
            Console.WriteLine("Nhap 1 so n: ");
            int n = Int16.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = r.Next(-100, 100);
            PrintArray(arr);
            for (int i = 0; i < n; i++)
                S = S + arr[i];
            Console.WriteLine("Tong cac so nguyen duong = " + S);
            do
            {
                Console.WriteLine("Nhap p [0, " + (n - 1) + "]:");
                p = Int16.Parse(Console.ReadLine());
            } while (p < 0 || p > (n - 1));
            for (int i = p + 1; i < n; ++i)
                arr[i - 1] = arr[i];
            for (int i = 0; i < n-1; i++)
                Console.Write(arr[i] + " ");
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
