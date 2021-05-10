using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proiect_PIU
{
    class Buget
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private string Tip { get; set; }
        private string Provenienta { get; set; }
        private int Suma { get; set; }
        private string Valuta { get; set; }

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
        public Buget(string text)
        {
            string[] BugetAray = text.Split(' ');
            Tip = BugetAray[0];
            Provenienta = BugetAray[1];
            setSuma(BugetAray[2]);            
            Valuta = BugetAray[3];
            
        }
        
        public int setSuma(string _suma)
        {
            int suma;
            if (Int32.TryParse(_suma, out suma))
                Suma = suma;
            return Suma;
        }
        public string ConversieLaSir()
        {

            string s = $"Aveti  {Tip} provenit din {Provenienta} {Suma} {Valuta}";
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
        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s=string.Empty;
            return s;
        }
    }
}
