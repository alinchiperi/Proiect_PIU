
using System;
using System.Collections;
using System.IO;


namespace Proiect_PIU
{
    public class  AdministrareBuget_FisierText : IstocareData
    {
        string NumeFisier { get; set; }

        public AdministrareBuget_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();           
          
        }
        public void AddBuget(Buget b)
        {
            throw new Exception("Optiunea AddBugetnu este implementata");
        }
        public ArrayList GetBugetTotal()
        {
            throw new Exception("Optiunea nu este implementata");
        }
    }
}
