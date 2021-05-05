
using System;
using System.Collections;
using System.IO;


namespace Proiect_PIU
{
    public class  AdministrareBuget_FisierText:IstocareData
    {
        string NumeFisier { get; set; }

        public AdministrareBuget_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
          
        }
    }
}
