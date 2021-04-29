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

		public Cheltuiala()
		{
			suma = 0;
			categoria = string.Empty;			
			valuta = string.Empty;
		}

		public Cheltuiala(string text)
        {
			string[] CheltuialaAray = text.Split(' ');
			categoria = CheltuialaAray[0];
			if (float.TryParse(CheltuialaAray[1], out suma))
			valuta = CheltuialaAray[2];
		}
		public string ConversieLaSir()
		{
			string venituri = "Nu exista ()";
			if (suma == 0)
			{
				venituri = Convert.ToString(suma);
			}
			string s = $"Aveti suma de platit {suma} {valuta}";

			return s;
		}

	}
}