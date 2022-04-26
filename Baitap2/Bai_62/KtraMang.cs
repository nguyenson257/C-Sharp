    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_62
{
    internal class KtraMang
    {
        static void Main(string[] args)
        {
            int  i, j, s1, s2;
            Console.WriteLine("Nhap 1 so n: ");
            int n = Int16.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random r = new Random();
            for (i = 0; i < n; i++)
                arr[i] = r.Next(10, 20);
            PrintArray(arr);

            for (s1 = s2 = i = 0; i < n; ++i)
            {
                if (i % 2 == 0 && arr[i] % 2 != 0) 
                    s1 += arr[i];
                if (i % 2 != 0 && arr[i] % 2 == 0) 
                    s2 += arr[i];
            }
            if (s1 == s2)
                Console.WriteLine("Tong le vi tri chan (" + s1 + ") bang tong chan vi tri le " + s2);
            else
                Console.WriteLine("Tong le vi tri chan (" + s1 + ") khac tong chan vi tri le " + s2);
            Console.WriteLine("Cac cap nguyen to cung nhau:");
            for (i = 0; i < n; ++i)
                for (j = i + 1; j < n; ++j)
                    if (arr[j] == arr[i]) arr[j--] = arr[--n];
            for (i = 0; i < n; ++i)
                for (j = i + 1; j < n; ++j)
                    if (gcd(arr[i], arr[j]) == 1)
                        Console.WriteLine("(" + arr[i] + ", " + arr[j] + ")");
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
        public static int gcd(int a, int b)
        {
            return (a==0) ? b : gcd(b % a, a);
        }
    }
}
