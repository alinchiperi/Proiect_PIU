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

namespace Interfata_WindowsForms
{
    public partial class Form1 : Form
    {
        IstocareData adminBuget = StocareFactory.GetAdministratorStocare();
        public const string VENIT = "Venit";
        public const string CHELTUIALA = "Cheltuiala";
        public const string ECONOMIE = "Economie";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (ValidareDateIntrare())
            {
                try
                {

                    Buget buget = new Buget(cbTip.Text, tbProvenienta.Text);                  
                    buget.setSuma(tbSuma.Text);
                    buget.Valuta = GetValuta();
                    adminBuget.AddBuget(buget);
                }
                catch (FormatException exe)
                {
                    MessageBox.Show("Error catch", exe.Message);
                }
            }
            
        }
        public bool ValidareDateIntrare()
        {
            bool status = true;
            if (cbTip.Text == "")
            { errorProvider1.SetError(cbTip, "selectati tipul"); status = false; }
            else if (tbProvenienta.Text == "")
            { errorProvider1.SetError(tbProvenienta, "Introduceti Provenienta"); status = false; }
            else if (tbSuma.Text == "")
            { errorProvider1.SetError(tbSuma, "Introduceti suma de bani"); status = false; }    
            else if(Convert.ToInt32( tbSuma.Text)<0)
            { errorProvider1.SetError(tbSuma, "Suma trebuie sa fie pozitiva"); status = false; }
            return status;
        }
        private String GetValuta()
        {
            if (rdbRon.Checked)
                return rdbRon.Text;
            if (rdbEuro.Checked)
                return rdbEuro.Text;
            if (rdbDolari.Checked)
                return rdbDolari.Text;
            return null;
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            lstbAfisare.Items.Clear();
            ArrayList Bugete = adminBuget.GetBugetTotal();                         
            
            foreach(Buget b in Bugete)
            {
                var linie = string.Format("{0,-5}{1,-35}{2,20}{3,10}\n", b.Tip, b.Provenienta, b.Suma, b.Valuta);
                lstbAfisare.Items.Add(linie);
            }
        }

        private void btnVenituri_Click(object sender, EventArgs e)
        {
            dgwDate.DataSource = null;
            dgwDate.Refresh();
            ArrayList venituri = adminBuget.GetBugetTotal(VENIT);
            dgwDate.DataSource=venituri;

        }

        private void btnCheltuieli_Click(object sender, EventArgs e)
        {
            dgwDate.DataSource = null;
            dgwDate.Refresh();
            ArrayList venituri = adminBuget.GetBugetTotal(CHELTUIALA);
            dgwDate.DataSource = venituri;

        }
        private void btnEconomii_Click(object sender, EventArgs e)
        {
            dgwDate.DataSource = null;
            dgwDate.Refresh();
            ArrayList venituri = adminBuget.GetBugetTotal(ECONOMIE);
            dgwDate.DataSource = venituri;
        }

        private void btnVenitTotal_Click(object sender, EventArgs e)
        {
            tbVenitTotal.Clear();
            ArrayList Bugete = adminBuget.GetBugetTotal();
            ArrayList venituri = new ArrayList();
            int suma = 0;
            foreach (Buget b in Bugete)
                if (b.Tip == VENIT)
                    venituri.Add(b);
            foreach (Buget b in venituri)
            {
                suma += b.Suma;
            }
            tbVenitTotal.Text = suma.ToString();
        }

        private void btnCheltuieliToatale_Click(object sender, EventArgs e)
        {
            tbCheltuieliTotale.Clear();
            ArrayList Bugete = adminBuget.GetBugetTotal();
            ArrayList venituri = new ArrayList();
            int suma = 0;
            foreach (Buget b in Bugete)
                if (b.Tip == CHELTUIALA)
                    venituri.Add(b);
            foreach (Buget b in venituri)
            {
                suma += b.Suma;
            }
            tbCheltuieliTotale.Text = suma.ToString();

        }

        private void btnEconomiiTotale_Click(object sender, EventArgs e)
        {
            tbEconomiiTotale.Clear();
            ArrayList Bugete = adminBuget.GetBugetTotal();
            ArrayList venituri = new ArrayList();
            int suma = 0;
            foreach (Buget b in Bugete)
                if (b.Tip == ECONOMIE)
                    venituri.Add(b);
            foreach (Buget b in venituri)
            {
                suma += b.Suma;
            }
            tbEconomiiTotale.Text = suma.ToString();
        }

        private void lstbAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
