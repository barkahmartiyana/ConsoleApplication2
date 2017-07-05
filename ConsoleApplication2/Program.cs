using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjang;
            int lebar;

            Console.Write("Masukan panjang:");
            panjang = int.Parse(Console.ReadLine());

            Console.Write("Masukan lebar: ");
            lebar = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------");
            Console.WriteLine("Luas persegi panjang: " + panjang * lebar);
            Console.WriteLine("Keliling persegi panjang: "  (2*panjang + 2*lebar) );
            Console.WriteLine("------------------");

            Console.ReadLine();
        }
    }
}
