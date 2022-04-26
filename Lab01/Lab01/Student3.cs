using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Student3
    {
        internal class People
        {
            private int ID;
            private string Ten;
            public People()
            {
                ID = 1;
                Ten = "Nguyen Van Nam";
            }

            public People(People stu)
            {
                ID = stu.ID;
                Ten = stu.Ten;
            }
            public People(int ID, string ten, string khoa, float diemTB)
            {
                ID = ID;
                Ten = ten;
            }

            public int gID
            {
                get { return ID; }
                set { ID = value; }
            }
            public string gsTen
            {
                get { return Ten; }
                set { Ten = value; }
            }
            
        }
        internal class Students:People
        {
            private string Khoa;
            private float DiemTB;

           
            public Students(People stu) : base(stu)
            {
                this.Khoa = Khoa1;
                this.DiemTB = DiemTB1;
            }

            public Students(int ID, string ten, string khoa, float diemTB) : base(ID, ten, khoa, diemTB)
            {
                this.Khoa1=khoa;
                this.DiemTB1 = DiemTB;
            }

            public Students()
            {
                Khoa = "CNTT";
                DiemTB = 7;
            }

            public string Khoa1 { get => Khoa; set => Khoa = value; }
            public float DiemTB1 { get => DiemTB; set => DiemTB = value; }
            public void Show()
            {
                Console.WriteLine("\nMSSV: {0}", this.gID);
                Console.WriteLine("Ten SV: {0}", this.gsTen);
                Console.WriteLine("Khoa: {0}", this.Khoa);
                Console.WriteLine("Diem TB: {0}", this.DiemTB);
            }

            public static Students Nhap1SV(Students std, int i)
            {
                std = new Students();
                Console.Write("\nNhap MaSV {0}: ", i + 1);
                std.gID = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV: ");
                std.gsTen = Console.ReadLine();
                Console.Write("Nhap khoa: ");
                std.Khoa1 = Console.ReadLine();
                Console.Write("Nhap Diem TB: ");
                std.DiemTB1 = float.Parse(Console.ReadLine());
                return std;
            }
            public static Students[] NhapDS(int n)
            {
                Students[] DSSV = new Students[n];
                Console.WriteLine("\n ====NHAP DS SINH VIEN====");
                for (int i = 0; i < n; i++) //Lap n lan nhap thong tin sv
                {
                    DSSV[i] = Nhap1SV(DSSV[i], i);
                }
                return DSSV;
            }
            public static void XuatDS(Students[] DSSV)
            {
                //Xuat DS Sinh vien
                Console.WriteLine("\n ====XUAT DS SINH VIEN====");
                foreach (Students sv in DSSV)
                    sv.Show();
                Console.ReadLine();
            }
            class Tester2
            {
                public static Students[] DSSV;

                public static void Main3()
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
}
