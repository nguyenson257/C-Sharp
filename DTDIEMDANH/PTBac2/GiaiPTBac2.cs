using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTBac2
{
    class GiaiPTBac2
    {
        private double a_46;
        private double b_46;
        private double c_46;

        public GiaiPTBac2(double a_46, double b_46, double c_46)
        {
            A_46 = a_46;
            B_46 = b_46;
            C_46 = c_46;
            giaiPT();
        }

        public double A_46 { get => a_46; set => a_46 = value; }
        public double B_46 { get => b_46; set => b_46 = value; }
        public double C_46 { get => c_46; set => c_46 = value; }

        public void giaiPT()
        {
            // kiem tra cac he so
            if (a_46 == 0)
            {
                if (b_46 == 0)
                {
                    Console.Write("Phuong trinh vo nghiem!");
                }
                else
                {
                    Console.Write("Phuong trinh co mot nghiem: x = " + (-c_46 / b_46));
                }
                return;
            }
            double delta_46 = b_46 * b_46 - 4 * a_46 * c_46;
            double x1_46;
            double x2_46;
            if (delta_46 > 0)
            {
                x1_46 = (double)((-b_46 + Math.Sqrt(delta_46)) / (2 * a_46));
                x2_46 = (double)((-b_46 - Math.Sqrt(delta_46)) / (2 * a_46));
                Console.Write("Phuong trinh co 2 nghiem la: x1 = "+ x1_46 + " va x2 = " + x2_46);
            }
            else if (delta_46 == 0)
            {
                x1_46 = (-b_46 / (2 * a_46));
                Console.Write("Phong trinh co nghiem kep: x1 = x2 = " + x1_46);
            }
            else
            {
                Console.Write("Phuong trinh vo nghiem!");
            }
        }
       
    }
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 3 so a, b, c:");
            Console.WriteLine("a = ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("c = ");
            double c = Double.Parse(Console.ReadLine());
            GiaiPTBac2 b2 = new GiaiPTBac2(a, b, c);
        }
    }
}
