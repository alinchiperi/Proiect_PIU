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
            if (tbTip.Text == "")
                errorProvider1.SetError(tbTip, "selectati tipul");
            else if (tbProvenienta.Text == "")
                errorProvider1.SetError(tbProvenienta, "Introduceti Provenienta");
            else if (tbSuma.Text == "")
                errorProvider1.SetError(tbSuma, "Introduceti suma de bani");
            else if (tbValuta.Text == "")
                errorProvider1.SetError(tbValuta, "introduceti Valuta");
            else if (Convert.ToInt32(tbSuma.Text) < 0)
                errorProvider1.SetError(tbSuma, "Suma trebuie sa fie pozitiva");
            else if (ckbRon.Checked)
               

            else
            {
                try
                {

                    Buget buget = new Buget(tbTip.Text, tbProvenienta.Text);
                    /* Buget buget = new Buget();
                     buget.Tip = tbTip.Text;
                     buget.Provenienta = tbProvenienta.Text;*/
                    buget.setSuma(tbSuma.Text);
                    buget.Valuta = tbValuta.Text;
                    adminBuget.AddBuget(buget);
                }
                catch (FormatException exe)
                {
                    MessageBox.Show("Error catch", exe.Message);
                }
            }
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
            lstbAfisare.Items.Clear();
            ArrayList Bugete = adminBuget.GetBugetTotal();
            ArrayList venituri = new ArrayList();
           foreach(Buget b in Bugete)
                if(b.Tip==VENIT)
                venituri.Add(b);

            foreach (Buget b in venituri)
            {
                var linie = string.Format("{0,-5}{1,-35}{2,20}{3,10}\n", b.Tip, b.Provenienta, b.Suma, b.Valuta);
                lstbAfisare.Items.Add(linie);
            }

        }

        private void btnCheltuieli_Click(object sender, EventArgs e)
        {
            lstbAfisare.Items.Clear();
            ArrayList Bugete = adminBuget.GetBugetTotal();
            ArrayList venituri = new ArrayList();
            foreach (Buget b in Bugete)
                if (b.Tip == CHELTUIALA)
                    venituri.Add(b);

            foreach (Buget b in venituri)
            {
                var linie = string.Format("{0,-5}{1,-35}{2,20}{3,10}\n", b.Tip, b.Provenienta, b.Suma, b.Valuta);
                lstbAfisare.Items.Add(linie);
            }

        }
    }
}
