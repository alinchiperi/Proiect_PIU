using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Proiect_PIU
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IstocareData  adminBuget = StocareFactory.GetAdministratorStocare();

            Buget b1 = new Buget("Venit", "Salariu", 14500, "Ron");
            Buget b2 = new Buget("Cheltuiala ","mancare",500 ,"Ron");
            Console.WriteLine (b1.ConversieLaSir());
            Console.WriteLine (b2.ConversieLaSir());
            if (b2 > b1)
                Console.WriteLine("Venit prea mic");
            else
                Console.WriteLine("Venit suficient");
            Console.WriteLine(b1.ConversieLaSir_PentruScriereInFisier());
            Console.WriteLine(b2.ConversieLaSir_PentruScriereInFisier());
            ArrayList bugetTotal;
            bugetTotal = adminBuget.GetBugetTotal();
            int nrbuget = bugetTotal.Count;
            bugetTotal.Add(b1);
            bugetTotal.Add(b2);
            adminBuget.AddBuget(b1);
            adminBuget.AddBuget(b2);
            Console.WriteLine("=================================");
            AfisareBuget(bugetTotal);
            Console.ReadKey();
        }
        public static void AfisareBuget(ArrayList BugetTotal)
        {
            Console.WriteLine("Buget:");
            for (int i = 0; i < BugetTotal.Count; i++)
            {
                Console.WriteLine(((Buget)BugetTotal[i]).ConversieLaSir());
            }
        }
    }
}
