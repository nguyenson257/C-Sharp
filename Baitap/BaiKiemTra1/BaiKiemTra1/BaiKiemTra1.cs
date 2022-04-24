using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra1
{
    internal class BaiKiemTra1
    {
        public void Bai1()
        {
            Console.WriteLine("Bai 1:");
            Console.WriteLine("Nhap vao 2 so: ");
            Console.Write("n1 = ");
            Double n1_46 = Double.Parse(Console.ReadLine()); 
            Console.Write("n2 = ");
            Double n2_46 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Tong cua 2 so tren la: " + n1_46 + " + " + n2_46 + " = " + (n1_46 + n2_46));
            Console.WriteLine("Hieu cua 2 so tren la: " + n1_46 + " - " + n2_46 + " = " + (n1_46 - n2_46));
            Console.WriteLine("Tich cua 2 so tren la: " + n1_46 + " * " + n2_46 + " = " + (n1_46 * n2_46));
            if(n2_46 == 0)
                Console.WriteLine("Khong the chia voi so 0 ");
            else
                Console.WriteLine("Thuong cua 2 so tren la: " + n1_46 + " / " + n2_46 + " = " + (n1_46 / n2_46));
            Console.ReadKey();
        }

        public void Bai2()
        {
            Console.WriteLine("Bai 2:");
            Console.WriteLine("La co Viet Nam");
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=                  +                   =");
            Console.WriteLine("=                 + +                  =");
            Console.WriteLine("=          + + + + + + + + +           =");
            Console.WriteLine("=            + + + + + + +             =");
            Console.WriteLine("=              + + + + +               =");
            Console.WriteLine("=             +  +   +  +              =");
            Console.WriteLine("=            +           +             =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================");
            Console.ReadKey();
        }
        public void Bai3()
        {
            Console.WriteLine("Bai 3:");
            Console.Write("Nhap vao 1 so thap phan: ");
            int n_46 = int.Parse(Console.ReadLine());
            int i_46;
            int[] nArray_46 = new int[10];
            for (i_46 = 0; n_46 > 0; i_46++)
            {
                nArray_46[i_46] = n_46 % 2;
                n_46 = n_46 / 2;
            }
            Console.Write("So thap phan sau khi chuyen doi: ");
            for (i_46 = i_46 - 1; i_46 >= 0; i_46--)
            {
                Console.Write(nArray_46[i_46]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public void Bai4()
        {
            Console.WriteLine("Bai 4:");
            Console.WriteLine("-----Thong tin sinh vien-----");
            Console.WriteLine("Ho va ten: Nguyen Hong Son");
            Console.WriteLine("Lop: 19T1");
            Console.WriteLine("Ma sinh vien: 1911505310146");
            Console.ReadKey();
        }
    }
    
    class program
    {
        static void Main(string[] args)
        {
            BaiKiemTra1 kt1 = new BaiKiemTra1();
            kt1.Bai1();
            kt1.Bai2();
            kt1.Bai3();
            kt1.Bai4();
        }
    }
}
