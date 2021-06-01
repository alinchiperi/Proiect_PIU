using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proiect_PIU;
using System.Collections;
using System.IO;

namespace Interfata_WindowsForms
{
    public partial class Bilant : Form
    {
        IstocareData adminBuget = StocareFactory.GetAdministratorStocare();
        public const string VENIT = "Venit";
        public const string CHELTUIALA = "Cheltuiala";
        public const string ECONOMIE = "Economie";
        public Bilant()
        {
            InitializeComponent();
        }
        public int SumaTotala(string tip)
        {
            int suma = 0;
            ArrayList venituri = adminBuget.GetBugetTotal(tip);
            foreach (Buget b in venituri)
            {
                suma += b.Suma;
            }
            return suma;
        }

        private void btnVenitTotal_Click(object sender, EventArgs e)
        {
            tbVenitTotal.Clear();
            int suma = 0;
            ArrayList venituri = adminBuget.GetBugetTotal(VENIT);
            foreach (Buget b in venituri)
            {
                suma += b.Suma;
            }
            tbVenitTotal.Text = suma.ToString();
        }
        private void btnCheltuieliToatale_Click(object sender, EventArgs e)
        {
            tbCheltuieliTotale.Clear();
            int suma = 0;
            ArrayList venituri = adminBuget.GetBugetTotal(CHELTUIALA);
            foreach (Buget b in venituri)
            {
                suma += b.Suma;
            }
            foreach (Buget b in venituri)
            {
                suma += b.Suma;
            }
            tbCheltuieliTotale.Text = suma.ToString();

        }

        private void btnEconomiiTotale_Click(object sender, EventArgs e)
        {
            tbEconomiiTotale.Clear();
            int suma = 0;
            ArrayList venituri = adminBuget.GetBugetTotal(ECONOMIE);
            foreach (Buget b in venituri)
            {
                suma += b.Suma;
            }
            tbEconomiiTotale.Text = suma.ToString();
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Venituri"].Points.AddXY(DateTime.Now,SumaTotala(VENIT));
            this.chart1.Series["Cheltuieli"].Points.AddXY(DateTime.Now,SumaTotala(CHELTUIALA));
            this.chart1.Series["Economii"].Points.AddXY(DateTime.Now,SumaTotala(ECONOMIE));
        }

       
    }
}
