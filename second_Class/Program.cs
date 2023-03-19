using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            Console.WriteLine("Xin moi nhap hai so nguyen a;b bat ky");
            Console.WriteLine("a=");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());

            //Tinh thuong va ep kieu du lieu
            double c = (double)a / b;
            Console.WriteLine("Thuong hai so a&b da nhap la {0} ",c);
            Console.Write("<------------------>\n");

            double d = a * (1.0f) / b;
            Console.WriteLine("Thuong hai so a&b da nhap la {0} ", d);
            Console.Write("<------------------>\n");

            //Tinh thuong bang phuong phap
            Console.WriteLine("Phan du cua phep chia a&b la "+ chia_lay_phan_du(a, b));

            Console.ReadKey();
        }
        static double chia_lay_phan_du(int a, int b)
        {
            double c = a % b;
            return c;
        }
    }
}
