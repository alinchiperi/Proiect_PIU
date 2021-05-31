using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proiect_PIU
{
    public class Buget
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        public string Tip { get; set; }
        public string Provenienta { get; set; }
        public int Suma { get; set; }
        public string Valuta { get; set; }
        public DateTime dataActualizare{get; set;}

        //constructori
        public Buget()
        {
            Tip = Provenienta=Valuta= string.Empty;            
            Suma = 0;
        }
        public Buget(string _tip, string _provenienta, int _suma, string _valuta)
        {
            Tip = _tip;
            Provenienta = _provenienta;
            Suma = _suma;
            Valuta = _valuta;
        }
        public Buget(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            Tip = dateFisier[(int)CampuriBuget.TIP];
            Provenienta = dateFisier[(int)CampuriBuget.PROVENIENTA];
            setSuma((dateFisier[(int)CampuriBuget.SUMA]));
            Valuta = dateFisier[(int)CampuriBuget.VALUTA];
            dataActualizare = DateTime.Parse( (dateFisier[(int)CampuriBuget.DATA]));
        }
        public Buget(string _tip, string _provenienta )
        {
            Tip = _tip;
            Provenienta = _provenienta;
        }
        public int setSuma(string _suma)
        {
            int suma;
            if (Int32.TryParse(_suma, out suma))
                Suma = suma;
            return Suma;
        }
        //functie pentru conversie la un sir de caractere
        public string ConversieLaSir()
        {

            string s = $" {Tip} provenit din {Provenienta}: {Suma} {Valuta}";
            return s;
        }
        public static bool operator > (Buget b1, Buget b2)
        {
            bool status = false;
            if (b1.Suma > b2.Suma)
                status = true;
            return status;
        }
        public static bool operator <(Buget b1, Buget b2)
        {
            bool status = false;
            if (b1.Suma < b2.Suma)
                status = true;
            return status;
        }
        //functie pentru a formata un buget pentru scrierea in fisier
        public string ConversieLaSir_PentruScriereInFisier()
        {
                       
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                SEPARATOR_PRINCIPAL_FISIER, Tip, (Provenienta ?? " NECUNOSCUT "), Suma, Valuta, dataActualizare );

            return s;
        }
    }
}
