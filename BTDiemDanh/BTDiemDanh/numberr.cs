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
            int[] arr_46 = new int[10];
            Console.WriteLine("Nhap vao 10 so nguyen: ");
            for(int i = 0; i < arr_46.Length; i++)
            {
                arr_46[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("So lon nhat trong day so tren la: " + FindMax(arr_46));
            Console.WriteLine("So lon nhat trong day so tren la: " + FindMin(arr_46));
            Console.WriteLine("Sap xep tang dan: ");
            Printarr(SoftAscen(arr_46));
            Console.WriteLine("Sap xep giam dan: ");
            Printarr(SoftDescen(arr_46));


        }
        public static void Printarr(int[] arr_46)
        {
            for (int i = 0; i < arr_46.Length; i++)
            {
                Console.Write(arr_46[i] + " ");
            }
            Console.WriteLine();
        }
        public static int FindMax(int[] arr_46)
        {
            int m;
            m = arr_46[0];
            for (int i = 0; i < arr_46.Length; i++)
            {
                if(arr_46[i] >= m)
                {
                    m = arr_46[i];
                }
            }
            return m;
        }
        public static int FindMin(int[] arr_46)
        {
            int m;
            m = arr_46[0];
            for (int i = 0; i < arr_46.Length; i++)
            {
                if (arr_46[i] <= m)
                {
                    m = arr_46[i];
                }
            }
            return m;
        }
        public static int[] SoftAscen(int[] arr_46)
        {
            for (int i = 0; i < arr_46.Length; i++)
            {
                for (int j = i + 1; j < arr_46.Length; j++)
                {
                    if (arr_46[i] > arr_46[j])
                    {
                        int temp = arr_46[i];
                        arr_46[i] = arr_46[j];
                        arr_46[j] = temp;
                    }
                }
            }
            return arr_46;
        }
        public static int[] SoftDescen(int[] arr_46)
        {
            for (int i = 0; i < arr_46.Length; i++)
            {
                for (int j = i + 1; j < arr_46.Length; j++)
                {
                    if (arr_46[i] < arr_46[j])
                    {
                        int temp = arr_46[i];
                        arr_46[i] = arr_46[j];
                        arr_46[j] = temp;
                    }
                }
            }
            return arr_46;
        }
    }
}
