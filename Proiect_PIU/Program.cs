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
            Venit v1 = new Venit( "Salariu",14500, "RON");
            Venit v2 = new Venit("Bursa 6.000,15 RON ");
            Cheltuiala c1 = new Cheltuiala("Mancare 750 RON");

            Console.WriteLine(v1.ConversieLaSir());
            Console.WriteLine(v2.ConversieLaSir());
            Console.WriteLine(v2.Suma);
            Console.ReadKey();
        }
    }
}
