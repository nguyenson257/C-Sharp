using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_60
{
    internal class TronMang
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap 1 so n chan: ");
                n = Int16.Parse(Console.ReadLine());
            }
            while (n % 2 != 0);
            int[] arr = new int[n];
            Random r = new Random();
            for(int i = 0; i < n; i++)
                arr[i] = r.Next(-100,100);
            PrintArray(arr);
            int[] res = Shuffle(arr);
            PrintArray(res);
            Count(arr);

        }
        public static int[] Shuffle(int[] array)
        {
            int half = array.Length / 2;
            int[] result = new int[array.Length];
            for (int t = 0, l = 0, r = half; l < half; t += 2, l++, r++)
            {
                result[t] = array[l];
                result[t + 1] = array[r];
            }
            return result;
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
        public static void Count(int[] a)
        {
            int count = 0;
            int[] b = a;
            do
            {
                b = Shuffle(b);
                count++;
            } while (!(bool)a.SequenceEqual(b));
            Console.WriteLine("Can " + count + " lan shuffle de mang tro ve ban dau");

        }
    }
}
