using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
	public class Venit
	{
		private float suma;
		private string provenienta;
		private string valuta;

		public Venit()
		{
			suma = 0;
			provenienta = string.Empty;
			valuta = string.Empty;
		}

		public Venit(float _suma, string _provenienta, string _valuta)
		{
			suma = _suma;
			provenienta = _provenienta;
			valuta = _valuta;
		}

		public Venit(string text)
		{
			string[] VenitAray = text.Split(' ');

			if (Single.TryParse(VenitAray[0], out suma))
			provenienta = VenitAray[1];
			valuta = VenitAray[2];



		}

		public string ConversieLaSir()
		{
			string venituri = "Nu exista (Nu ati apelat metoda **setNote**)";
			if (suma == null)
			{
				venituri = Convert.ToString(suma);
			}
			string s = $"Aveti urmatorul venit {suma} {valuta}";

			return s;
		}
	}
}
