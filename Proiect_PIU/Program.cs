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
            Venit v1 = new Venit(14500, "Salariu", "RON");

            Console.WriteLine(v1.ConversieLaSir());
            Console.ReadKey();
        }
    }
}
