using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student()
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student(Student stu)
        {
            SID=stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        public Student(int sID, string tenSV, string khoa, float diemTB)
        {
            SID = sID;
            TenSV = tenSV;
            Khoa = khoa;
            DiemTB = diemTB;
        }

        public int StudentID { get => SID; set => SID = value; }
        public string Name { get => TenSV; set => TenSV = value; }
        public string Faculty { get => Khoa; set => Khoa = value; }
        public float Mark { get => DiemTB; set => DiemTB = value; }

        public void Show()
        {
            Console.WriteLine("\nMSSV: {0}", this.SID);
            Console.WriteLine("Ten SV: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem TB: {0}", this.DiemTB);
        }
        class Tester
        {
            public static void Main1()
            {
                Student[] DSSV;
                int n;
                Console.Write("Nhap so luong SV: ");
                n = int.Parse(Console.ReadLine());
                DSSV = new Student[n]; //tao mang n phan tu
                Console.WriteLine("\n ====NHAP DS SINH VIEN====");
                for (int i = 0; i < n; i++) //Lap n lan nhap thong tin sv
                {
                    DSSV[i] = new Student();
                    Console.Write("\nNhap MaSV {0}: ", i + 1);
                    DSSV[i].StudentID = int.Parse(Console.ReadLine());
                    Console.Write("Ho ten SV: ");
                    DSSV[i].Name = Console.ReadLine();
                    Console.Write("Nhap khoa: ");
                    DSSV[i].Faculty = Console.ReadLine();
                    Console.Write("Nhap Diem TB: ");
                    DSSV[i].Mark = float.Parse(Console.ReadLine());
                }
                //Xuat DS Sinh vien
                Console.WriteLine("\n ====XUAT DS SINH VIEN====");
                foreach (Student sv in DSSV)
                    sv.Show();
                Console.ReadLine();
            }
        }
    }
}
