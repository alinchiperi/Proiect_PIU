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
                    if (ckbSalariu.Checked)
                        tbProvenienta.Text = ckbSalariu.Text;
                    else if (ckbFacturi.Checked)
                        tbProvenienta.Text = ckbFacturi.Text;
          
                    Buget buget = new Buget(cbTip.Text, tbProvenienta.Text);                  
                    buget.setSuma(tbSuma.Text);
                    buget.Valuta = GetValuta();
                    buget.dataActualizare = DateTime.Now;
                    adminBuget.AddBuget(buget);
                    
                }
                catch (FormatException exe)
                {
                    MessageBox.Show("Error catch", exe.Message);
                }
                ResetareButoane();
            }            
        }
        public bool ValidareDateIntrare()
        {
            bool status = true;
            if (cbTip.Text == "")
            { errorProvider1.SetError(cbTip, "selectati tipul"); status = false; }
           /* else if (tbProvenienta.Text == "" && !ckbSalariu.Checked || !ckbFacturi.Checked )
            { errorProvider1.SetError(tbProvenienta, "Introduceti Provenienta"); status = false; }*/
            else if (tbSuma.Text == "")
            { errorProvider1.SetError(tbSuma, "Introduceti suma de bani"); status = false; }    
            else if(Convert.ToInt32( tbSuma.Text)<0)
            { errorProvider1.SetError(tbSuma, "Suma trebuie sa fie pozitiva"); status = false; }
            return status;
        }
        public void ResetareButoane()
        {
            cbTip.Text = tbProvenienta.Text = tbSuma.Text = string.Empty;
            rdbRon.Checked = false;
            rdbEuro.Checked = false;
            rdbDolari.Checked = false;
            ckbFacturi.Checked = false;
            ckbSalariu.Checked = false;
            errorProvider1.Clear();

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
           
            ArrayList Bugete = adminBuget.GetBugetTotal();
            dgwDate.DataSource = Bugete;
                  
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

        private void btnModifica_Click(object sender, EventArgs e)
        {        
           Buget buget = adminBuget.GetBuget(cbTip.Text, tbProvenienta.Text);
            /*buget.Tip = cbTip.Text;
            buget.Provenienta = tbProvenienta.Text;*/
            buget.setSuma(tbSuma.Text);
            buget.Valuta = GetValuta();
            buget.dataActualizare = DateTime.Now;
            //Modificare date
            if (ValidareDateIntrare())
            adminBuget.UpdateBuget(buget);
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|bin files (*.bin)|*.bin|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, true))
                    for (int i = 0; i < dgwDate.Rows.Count ; i++)
                    {
                    for (int j = 0; j < dgwDate.Columns.Count-1; j++)
                    {
                        writer.Write("\t" + dgwDate.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("-----------------------------------------------------");
                }
               
            }
        }

        private void btnBilant_Click(object sender, EventArgs e)
        {
            Bilant bilant = new Bilant();
            bilant.Show();
        }

        private void dgwDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgwDate.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                cbTip.Text = dgwDate.Rows[e.RowIndex].Cells["Tip"].FormattedValue.ToString();
                tbProvenienta.Text= dgwDate.Rows[e.RowIndex].Cells["Provenienta"].FormattedValue.ToString();
                tbSuma.Text= dgwDate.Rows[e.RowIndex].Cells["Suma"].FormattedValue.ToString();
                if (dgwDate.Rows[e.RowIndex].Cells["Valuta"].FormattedValue.ToString() == "Ron")
                    rdbRon.Checked = true;
            }
        }

        private void BtnCauta_Click(object sender, EventArgs e)
        {
            dgwDate.DataSource = null;
            dgwDate.Refresh();
            string prov = tbProvenienta.Text;
            ArrayList Bugete = adminBuget.GetBugetTotal();
            ArrayList filtrare = new ArrayList();
            foreach (Buget b in Bugete)
                if (b.Provenienta == prov)
                    filtrare.Add(b);
            dgwDate.DataSource = filtrare;
            ResetareButoane();
        }
    }
}
