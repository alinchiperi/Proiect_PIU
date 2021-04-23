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
            Venit v1 = new Venit(14500, "RON", "Salariu");
            Venit v2 = new Venit("600.15,  RON, Bursa");

            Console.WriteLine(v1.ConversieLaSir());
            Console.WriteLine(v2.ConversieLaSir());
            Console.ReadKey();
        }
    }
}
