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
            Buget b1 = new Buget("Venit", "Salariu", 14500, "Ron");
            Buget b2 = new Buget("Cheltuiala mancare 500 Ron");
            Console.WriteLine (b1.ConversieLaSir());
            Console.WriteLine (b2.ConversieLaSir());
            if (b2 > b1)
                Console.WriteLine("Venit prea mic");
            else
                Console.WriteLine("Venit suficient");                       

            Console.ReadKey();
        }
    }
}
