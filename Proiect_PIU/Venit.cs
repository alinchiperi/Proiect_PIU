using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
	public class Venit
	{
		private string provenienta;
		private float suma;
		private string valuta;

		public Venit()
		{
			suma = 0;
			provenienta = string.Empty;
			valuta = string.Empty;
		}

		public Venit(string _provenienta, float _suma, string _valuta)
		{
			suma = _suma;
			provenienta = _provenienta;
			valuta = _valuta;
		}

		public Venit(string text)
		{
			string[] VenitAray = text.Split(' ');
			provenienta = VenitAray[0];
			if (float.TryParse(VenitAray[1], out suma))
			{
				valuta = VenitAray[2];
			}
		}

		public string ConversieLaSir()
		{
			
			string s = $"Aveti urmatorul venit provenit din {provenienta} {suma} {valuta}";
			return s;
		}
		public static bool operator > (Venit v1, Venit v2)
        {
			bool status= false;
			if (v1.suma > v2.suma)
				status = true;
			return status;
        }
		public static bool operator <(Venit v1, Venit v2)
		{
			bool status = false;
			if (v1.suma < v2.suma)
				status = true;
			return status;
		}
		public float Suma
        {
			get { return suma; }
			set { }
	    }
	}
}
