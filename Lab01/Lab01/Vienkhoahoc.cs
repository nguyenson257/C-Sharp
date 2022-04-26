using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class NhaQuanLy
    {
        protected string HoTen;
        protected string NamSinh;
        protected string BangCap;
        protected string ChucVu;
        protected int NgayCong;
        protected int BacLuong;

        public NhaQuanLy()
        {
            HoTen = "a";
            NamSinh = "2001";
            BangCap = "a";
            ChucVu = "a";
            NgayCong = 1;
        }
        public NhaQuanLy(NhaQuanLy Nql)
        {
            HoTen = Nql.HoTen;
            NamSinh = Nql.NamSinh;
            BangCap = Nql.BangCap;
            ChucVu = Nql.ChucVu;
            NgayCong = Nql.NgayCong;
            BacLuong = Nql.BacLuong;
        }

        public NhaQuanLy(string hoTen, string namSinh, string bangCap, string chucVu, int ngayCong, int bacLuong)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            BangCap = bangCap;
            ChucVu = chucVu;
            NgayCong = ngayCong;
            BacLuong = bacLuong;
        }

        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public string BangCap1 { get => BangCap; set => BangCap = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }
        public int NgayCong1 { get => NgayCong; set => NgayCong = value; }
        public int BacLuong1 { get => BacLuong; set => BacLuong = value; }
        public void Show()
        {
            Console.WriteLine("\nHo va ten: {0}", this.HoTen);
            Console.WriteLine("Nam sinh: {0}", this.NamSinh);
            Console.WriteLine("Bang cap: {0}", this.BangCap);
            Console.WriteLine("Chuc vu: {0}", this.ChucVu);
            Console.WriteLine("Ngay cong: {0}", this.NgayCong);
            Console.WriteLine("Bac luong: {0}", this.BacLuong);
        }
        public static NhaQuanLy Nhap1NQL(NhaQuanLy std, int i)
        {
            std = new NhaQuanLy();
            Console.Write("\nNhap Ho va ten {0}: ", i + 1);
            std.HoTen1 = Console.ReadLine(); ;
            Console.Write("Nam sinh: ");
            std.NamSinh1 = Console.ReadLine();
            Console.Write("Bang cap: ");
            std.BangCap1 = Console.ReadLine();
            Console.Write("Chuc vu: ");
            std.ChucVu1 = Console.ReadLine(); ;
            Console.Write("Ngay cong: ");
            std.NgayCong1 = int.Parse(Console.ReadLine());
            Console.Write("Bac luong: ");
            std.BacLuong1 = int.Parse(Console.ReadLine());
            return std;
        }
        public static NhaQuanLy[] NhapDSNQL()
        {
            int n;
            Console.Write("Nhap so luong nha quan ly: ");
            n = int.Parse(Console.ReadLine());
            NhaQuanLy[] DSSV = new NhaQuanLy[n];
            Console.WriteLine("\n ====NHAP DS NHA QUAN LY====");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = Nhap1NQL(DSSV[i], i);
            }
            return DSSV;
        }
        public static void XuatDSNQL(NhaQuanLy[] DSSV)
        {
            //Xuat DS Sinh vien
            Console.WriteLine("\n ====XUAT DS NHA QUAN LY====");
            foreach (NhaQuanLy sv in DSSV)
                sv.Show();
        }
        public static void InLuong(NhaQuanLy[] DSSV)
        {
            //Xuat DS Sinh vien
            int s=0;
            Console.WriteLine("\n ====TONG LUONG NHA QUAN LY====");
            foreach (NhaQuanLy sv in DSSV)
                s = s + sv.NgayCong * sv.BacLuong;
            Console.WriteLine("Tong luong cua cac nha quan ly: {0}", s);
            Console.ReadLine();
        }
        public void RunNQL(NhaQuanLy[] DSSV)
        {
            DSSV = NhapDSNQL();
            XuatDSNQL(DSSV);
            InLuong(DSSV);
        }
    }
    internal class NhaKhoaHoc : NhaQuanLy
    {
        private int BaiBao;

        public NhaKhoaHoc()
        {
            this.BaiBao = 1;
        }

        public NhaKhoaHoc(NhaQuanLy Nql) : base(Nql)
        {
            this.BaiBao = BaiBao1;
        }

        public NhaKhoaHoc(string hoTen, string namSinh, string bangCap, string chucVu, int ngayCong, int bacLuong) : base(hoTen, namSinh, bangCap, chucVu, ngayCong, bacLuong)
        {
            this.BaiBao = BaiBao1;
        }

        public int BaiBao1
        {
            get => BaiBao;
            set => BaiBao = value;
        }
        public void Show()
        {
            Console.WriteLine("\nHo va ten: {0}", this.HoTen);
            Console.WriteLine("Nam sinh: {0}", this.NamSinh);
            Console.WriteLine("Bang cap: {0}", this.BangCap);
            Console.WriteLine("Chuc vu: {0}", this.ChucVu);
            Console.WriteLine("So bai bao: {0}", this.BaiBao);
            Console.WriteLine("Ngay cong: {0}", this.NgayCong);
            Console.WriteLine("Bac luong: {0}", this.BacLuong);
        }
        public static NhaKhoaHoc Nhap1NKH(NhaKhoaHoc std, int i)
        {
            std = new NhaKhoaHoc();
            Console.Write("\nNhap Ho va ten {0}: ", i + 1);
            std.HoTen1 = Console.ReadLine(); ;
            Console.Write("Nam sinh: ");
            std.NamSinh1 = Console.ReadLine();
            Console.Write("Bang cap: ");
            std.BangCap1 = Console.ReadLine();
            Console.Write("Chuc vu: ");
            std.ChucVu1 = Console.ReadLine(); ;
            Console.Write("So bai bao: ");
            std.BaiBao1 = int.Parse(Console.ReadLine());
            Console.Write("Ngay cong: ");
            std.NgayCong1 = int.Parse(Console.ReadLine());
            Console.Write("Bac luong: ");
            std.BacLuong1 = int.Parse(Console.ReadLine());
            return std;
        }
        public static NhaKhoaHoc[] NhapDSNKH()
        {
            int n;
            Console.Write("Nhap so luong nha khoa hoc: ");
            n = int.Parse(Console.ReadLine());
            NhaKhoaHoc[] DSSV = new NhaKhoaHoc[n];
            Console.WriteLine("\n ====NHAP DS NHA KHOA HOC====");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = Nhap1NKH(DSSV[i], i);
            }
            return DSSV;
        }
        public static void XuatDSNKH(NhaKhoaHoc[] DSSV)
        {
            //Xuat DS Sinh vien
            Console.WriteLine("\n ====XUAT DS NHA KHOA HOC====");
            foreach (NhaKhoaHoc sv in DSSV)
                sv.Show();
        }
        public static void InLuong(NhaKhoaHoc[] DSSV)
        {
            //Xuat DS Sinh vien
            int s = 0;
            Console.WriteLine("\n ====TONG LUONG NHA KHOA HOC====");
            foreach (NhaKhoaHoc sv in DSSV)
                s = s + sv.NgayCong * sv.BacLuong;
            Console.WriteLine("Tong luong cua cac nha khoa hoc: {0}", s);
            Console.ReadLine();
        }
        public void RunNQL(NhaKhoaHoc[] DSSV)
        {
            DSSV = NhapDSNKH();
            XuatDSNKH(DSSV);
            InLuong(DSSV);
        }
    }
    internal class NhanVien 
    {
        private string HoTen;
        private string NamSinh;
        private string BangCap;
        private int Luong;
        public NhanVien()
        {
            HoTen = "a";
            NamSinh = "2001";
            BangCap = "a";
            Luong =2000000;
        }
        public NhanVien(NhanVien NV)
        {
            HoTen = NV.HoTen;
            NamSinh = NV.NamSinh;
            BangCap = NV.BangCap;
            Luong = NV.Luong;
        }
        public NhanVien(string hoTen, string namSinh, string bangCap, int luong)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            BangCap = bangCap;
            Luong = luong;
        }

        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public string BangCap1 { get => BangCap; set => BangCap = value; }
        public int Luong1 { get => Luong; set => Luong = value; }

        public void Show()
        {
            Console.WriteLine("\nHo va ten: {0}", this.HoTen);
            Console.WriteLine("Nam sinh: {0}", this.NamSinh);
            Console.WriteLine("Bang cap: {0}", this.BangCap);
            Console.WriteLine("Luong: {0}", this.Luong);
        }
        public static NhanVien Nhap1NV(NhanVien std, int i)
        {
            std = new NhanVien();
            Console.Write("\nNhap Ho va ten {0}: ", i + 1);
            std.HoTen1 = Console.ReadLine(); ;
            Console.Write("Nam sinh: ");
            std.NamSinh1 = Console.ReadLine();
            Console.Write("Bang cap: ");
            std.BangCap1 = Console.ReadLine();
            Console.Write("Luong: ");
            std.Luong1 = int.Parse(Console.ReadLine());
            return std;
        }
        public static NhanVien[] NhapDSNV()
        {
            int n;
            Console.Write("Nhap so luong nhan vien: ");
            n = int.Parse(Console.ReadLine());
            NhanVien[] DSSV = new NhanVien[n];
            Console.WriteLine("\n ====NHAP DS NHAN VIEN====");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = Nhap1NV(DSSV[i], i);
            }
            return DSSV;
        }
        public static void XuatDSNKH(NhanVien[] DSSV)
        {
            //Xuat DS Sinh vien
            Console.WriteLine("\n ====XUAT DS NHAN VIEN====");
            foreach (NhanVien sv in DSSV)
                sv.Show();
        }
        public static void InLuong(NhanVien[] DSSV)
        {
            //Xuat DS Sinh vien
            int s = 0;
            Console.WriteLine("\n ====TONG LUONG NHAN VIEN====");
            foreach (NhanVien sv in DSSV)
                s = s + sv.Luong;
            Console.WriteLine("Tong luong cua cac nhan vien: {0}", s);
            Console.ReadLine();
        }
        public void RunNQL(NhanVien[] DSSV)
        {
            DSSV = NhapDSNV();
            XuatDSNKH(DSSV);
            InLuong(DSSV);
        }
    }
    internal class VienKhoaHoc
    {
        public static NhaQuanLy[] DSQL;
        public static NhaKhoaHoc[] DSKH;
        public static NhanVien[] DSSV;

        public static void Main()
        {
            NhaQuanLy Nql = new NhaQuanLy();
            Nql.RunNQL(DSQL);

            NhaKhoaHoc Nkh = new NhaKhoaHoc();
            Nkh.RunNQL(DSKH);

            NhanVien Nv = new NhanVien();
            Nv.RunNQL(DSSV);
        }
    }
}
