using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week6_2");
            int R = 10,r;
            const double PI = 3.1415;
            Console.WriteLine("半徑:"+ R +"，圓周長:" + (2*PI*R));
            Console.Write("請輸入半徑r:");
            r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("半徑:" + r + "，圓周長:" + (2*PI*r));
            Console.ReadLine();
        }
    }
}
