using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDaHinh
{
    class Hinh
    {
        protected string Ten;
        protected string ThuocTinh;
    }

    class TamGiac : Hinh
    {
        public TamGiac()
        {
            Ten = "Hinh Tam Giac";
            ThuocTinh = "La1 da giac co 3 dinh khong thang hang va 3 canh noi 3 dinh do.";
        }
    }

    class TuGiac : Hinh
    {
        public TuGiac()
        {
            Ten = "Hinh Tu Giac";
            ThuocTinh = "La 1 da giac co 4 dinh va 4 canh.";
        }
    }
    class BinhHanh : Hinh
    {
        public BinhHanh()
        {
            Ten = "Hinh Binh Hanh";
            ThuocTinh = "La 1 tu giac duoc tao thanh khi 2 cap duong thang song song va cat nhau";
        }
    }
    class ChuNhat : Hinh
    {
        public ChuNhat()
        {
            Ten = "Hinh Chu Nhat";
            ThuocTinh = "La 1 tu giac loi co 4 goc vuong.";
        }
    }
    class Vuong : Hinh
    {
        public Vuong()
        {
            Ten = "Hinh Vuong";
            ThuocTinh = "La 1 tu giac co 4 canh bang nhau vaf 4 goc bang nhau.";
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chon hinh de xem thong tin:");
            Console.WriteLine("1. Hinh tam giac");
            Console.WriteLine("2. Hinh tu giac");
            Console.WriteLine("3. Hinh binh hanh");
            Console.WriteLine("4. Hinh chu nhat");
            Console.WriteLine("5. Hinh vuong");

        }
    }
}
