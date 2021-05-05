using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    class Economie
    {
		private string categoria;
		private float suma;
		private string valuta;
		public Economie()
		{
			suma = 0;
			categoria = string.Empty;
			valuta = string.Empty;
		}
		public Economie(string text)
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
			string s = $"Ati economisit {suma} {valuta}";

			return s;
		}
		
	}
}
