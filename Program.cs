using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            D1.Print();
            Duration D5 = new Duration(25, 65, 25);
            D5.Print();
            Duration D2 = new Duration(3600);
            D2.Print();
            Duration D3 = new Duration(7800);
            D3.Print();
            Duration D4 = new Duration(666);
            D4.Print();
            Duration result = D1 + D5;
            result.Print();
            //Duration result1 = D1 + 7800;
            //result1.Print();
            //if (D1 > D2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if (D1 <= D2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
        }
    }
}
