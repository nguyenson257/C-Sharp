using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganHang
{
    internal class TinhLai
    {
        static void Main(string[] args)
        {
            int n, t;
            double tl, l;
            Console.WriteLine("Nhap so tien gui: ");
            t = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Nhap lai suat 1 nam: ");
            l = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nam gui: ");
            n = Int16.Parse(Console.ReadLine());

            tl = t * (Math.Pow((1 + l), n));
            Console.WriteLine("Sau " + n + " nam se nhan duoc so tien " + tl);

        }
    }
}
