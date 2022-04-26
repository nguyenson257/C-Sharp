using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_63
{
    internal class demso
    {
        static void Main(string[] args)
        {
            int p, S = 0;
            Console.WriteLine("Nhap 1 so n: ");
            int n = Int16.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = r.Next(-100, 100);
            PrintArray(arr);
            DemSo(arr);
            ThaySo(arr);
        }
        public static void DemSo(int[] array)
        {
            int c=0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 4 == 0 && array[i] % 10 == 6) 
                    c++;
            Console.WriteLine("Co " + c + " phan tu chia het cho 4, tan cung 6");
        }
        public static void ThaySo(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0 )
                    array[i] = array[i] * 2;
            PrintArray(array);
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
