
using System;
using System.Collections;

namespace Proiect_PIU
{
    public class AdministrareBuget_FisierBinar : IstocareData
    {
        string NumeFisier { get; set; }
        public AdministrareBuget_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }
        public void AddBuget(Buget b)
        {
            throw new Exception("Optiunea AddBuget nu este implementata");
        }
        public ArrayList GetBugetTotal()
        {
            throw new Exception("Optiunea nu este implementata");
        }
        public Buget GetBuget(string tip, string provenienta)
        {
            throw new Exception("Optiune neimplementata");
        }

    }
}
