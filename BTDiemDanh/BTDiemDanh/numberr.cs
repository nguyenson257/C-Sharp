using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDiemDanh
{
    internal class numberr
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Nhap vao 10 so nguyen: ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("So lon nhat trong day so tren la: " + FindMax(arr));
            Console.WriteLine("So lon nhat trong day so tren la: " + FindMin(arr));
            Console.WriteLine("Sap xep tang dan: ");
            PrintArr(SoftAscen(arr));
            Console.WriteLine("Sap xep giam dan: ");
            PrintArr(SoftDescen(arr));


        }
        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static int FindMax(int[] arr)
        {
            int m;
            m = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= m)
                {
                    m = arr[i];
                }
            }
            return m;
        }
        public static int FindMin(int[] arr)
        {
            int m;
            m = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= m)
                {
                    m = arr[i];
                }
            }
            return m;
        }
        public static int[] SoftAscen(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public static int[] SoftDescen(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
