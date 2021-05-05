using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Venit v1 = new Venit( 14500, "RON");
            Venit v2 = new Venit("Bursa 6.000,15 RON ");
            Cheltuiala c1 = new Cheltuiala("Mancare 750 RON");
            Economie e1 = new Economie("Masina 100 Ron");
            Console.WriteLine(v1.ConversieLaSir());
            Console.WriteLine(v2.ConversieLaSir());
            Console.WriteLine(c1.ConversieLaSir());
            Console.WriteLine(e1.ConversieLaSir());

            

            Console.ReadKey();
        }
    }
}
