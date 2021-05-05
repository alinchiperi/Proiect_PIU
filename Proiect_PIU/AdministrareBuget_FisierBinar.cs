
using System;
using System.Collections;

namespace Proiect_PIU
{
    public class AdministrareBuget_FisierBinar:IstocareData
    {
        string NumeFisier { get; set; }
        public AdministrareBuget_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }
    }
}
