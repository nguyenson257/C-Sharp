using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Student2
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student2()
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student2(Student2 stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        public Student2(int sID, string tenSV, string khoa, float diemTB)
        {
            SID = sID;
            TenSV = tenSV;
            Khoa = khoa;
            DiemTB = diemTB;
        }

        public int gsSID
        {
            get { return SID; }
            set { SID = value; }
        }
        public string gsTenSV
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public string gsKhoa
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float gsDiemTB
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        public void Show()
        {
            Console.WriteLine("\nMSSV: {0}", this.SID);
            Console.WriteLine("Ten SV: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem TB: {0}", this.DiemTB);
        }

        public static Student2 Nhap1SV(Student2 std,int i)
        {
            std = new Student2();
            Console.Write("\nNhap MaSV {0}: ", i + 1);
            std.gsSID = int.Parse(Console.ReadLine());
            Console.Write("Ho ten SV: ");
            std.gsTenSV = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            std.gsKhoa = Console.ReadLine();
            Console.Write("Nhap Diem TB: ");
            std.gsDiemTB = float.Parse(Console.ReadLine());
            return std;
        }
        public static Student2[] NhapDS(int n)
        {
            Student2[] DSSV = new Student2[n];
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++) //Lap n lan nhap thong tin sv
            {
                DSSV[i] = Nhap1SV(DSSV[i],i);
            }
            return DSSV;
        }
        public static void XuatDS(Student2[] DSSV)
        {
            //Xuat DS Sinh vien
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student2 sv in DSSV)
                sv.Show();
            Console.ReadLine();
        }
        class Tester2
        {
            public static Student2[] DSSV;

            public static void Main2()
            {
                int n;
                Console.Write("Nhap so luong SV: ");
                n = int.Parse(Console.ReadLine());
                DSSV = NhapDS(n);
                XuatDS(DSSV);
                
            }
        }
    }
}
