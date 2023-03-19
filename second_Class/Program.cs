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
            Console.WriteLine("Xin moi nhap hai so nguyen a;b bat ky");
            Console.WriteLine("a=");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Hai so a;b da nhap la " + a + " ; " + b);
            Console.ReadKey();
        }
    }
}
