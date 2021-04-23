using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
	public class Cheltuiala
	{
		private string categoria;
		private float suma;		
		private string valuta;
		private string importanta;

		public Cheltuiala()
		{
			suma = 0;
			categoria = string.Empty;
			importanta = String.Empty;
			valuta = string.Empty;
		}

		public Cheltuiala(string text)
        {
			string[] CheltuialaAray = text.Split(' ');
			categoria = CheltuialaAray[0];
			if (Single.TryParse(CheltuialaAray[0], out suma)) ;



		}

		public string ConversieLaSir()
		{
			string venituri = "Nu exista (Nu ati apelat metoda **setNote**)";
			if (suma == null)
			{
				venituri = Convert.ToString(suma);
			}
			string s = $"Aveti suma de platit {suma} {valuta}";

			return s;
		}

	}
}