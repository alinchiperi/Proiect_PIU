
namespace Interfata_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTip = new System.Windows.Forms.Label();
            this.lblProveninenta = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblValuta = new System.Windows.Forms.Label();
            this.tbProvenienta = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.btnVenituri = new System.Windows.Forms.Button();
            this.btnCheltuieli = new System.Windows.Forms.Button();
            this.btnEconomii = new System.Windows.Forms.Button();
            this.gbValuta = new System.Windows.Forms.GroupBox();
            this.rdbDolari = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbRon = new System.Windows.Forms.RadioButton();
            this.dgwDate = new System.Windows.Forms.DataGridView();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnBilant = new System.Windows.Forms.Button();
            this.lblGestiune = new System.Windows.Forms.Label();
            this.ckbSalariu = new System.Windows.Forms.CheckBox();
            this.ckbFacturi = new System.Windows.Forms.CheckBox();
            this.BtnCauta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbValuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(68, 112);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(22, 13);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Tip";
            // 
            // lblProveninenta
            // 
            this.lblProveninenta.AutoSize = true;
            this.lblProveninenta.Location = new System.Drawing.Point(68, 144);
            this.lblProveninenta.Name = "lblProveninenta";
            this.lblProveninenta.Size = new System.Drawing.Size(64, 13);
            this.lblProveninenta.TabIndex = 1;
            this.lblProveninenta.Text = "Provenienta";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(84, 227);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(34, 13);
            this.lblSuma.TabIndex = 2;
            this.lblSuma.Text = "Suma";
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(84, 275);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(37, 13);
            this.lblValuta.TabIndex = 3;
            this.lblValuta.Text = "Valuta";
            // 
            // tbProvenienta
            // 
            this.tbProvenienta.Location = new System.Drawing.Point(141, 141);
            this.tbProvenienta.Name = "tbProvenienta";
            this.tbProvenienta.Size = new System.Drawing.Size(100, 20);
            this.tbProvenienta.TabIndex = 5;
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(141, 224);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(100, 20);
            this.tbSuma.TabIndex = 6;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdauga.Location = new System.Drawing.Point(95, 346);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(123, 43);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(316, 321);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(80, 34);
            this.btnAfisare.TabIndex = 10;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Venit",
            "Cheltuiala",
            "Economie"});
            this.cbTip.Location = new System.Drawing.Point(141, 112);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(100, 21);
            this.cbTip.TabIndex = 11;
            // 
            // btnVenituri
            // 
            this.btnVenituri.BackColor = System.Drawing.Color.LightGreen;
            this.btnVenituri.Location = new System.Drawing.Point(316, 356);
            this.btnVenituri.Name = "btnVenituri";
            this.btnVenituri.Size = new System.Drawing.Size(80, 33);
            this.btnVenituri.TabIndex = 14;
            this.btnVenituri.Text = "Venituri";
            this.btnVenituri.UseVisualStyleBackColor = false;
            this.btnVenituri.Click += new System.EventHandler(this.btnVenituri_Click);
            // 
            // btnCheltuieli
            // 
            this.btnCheltuieli.BackColor = System.Drawing.Color.Crimson;
            this.btnCheltuieli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheltuieli.Location = new System.Drawing.Point(401, 356);
            this.btnCheltuieli.Name = "btnCheltuieli";
            this.btnCheltuieli.Size = new System.Drawing.Size(78, 33);
            this.btnCheltuieli.TabIndex = 15;
            this.btnCheltuieli.Text = "Cheltuieli";
            this.btnCheltuieli.UseVisualStyleBackColor = false;
            this.btnCheltuieli.Click += new System.EventHandler(this.btnCheltuieli_Click);
            // 
            // btnEconomii
            // 
            this.btnEconomii.BackColor = System.Drawing.Color.Gold;
            this.btnEconomii.Location = new System.Drawing.Point(485, 356);
            this.btnEconomii.Name = "btnEconomii";
            this.btnEconomii.Size = new System.Drawing.Size(77, 33);
            this.btnEconomii.TabIndex = 16;
            this.btnEconomii.Text = "Economii";
            this.btnEconomii.UseVisualStyleBackColor = false;
            this.btnEconomii.Click += new System.EventHandler(this.btnEconomii_Click);
            // 
            // gbValuta
            // 
            this.gbValuta.Controls.Add(this.rdbDolari);
            this.gbValuta.Controls.Add(this.rdbEuro);
            this.gbValuta.Controls.Add(this.rdbRon);
            this.gbValuta.Location = new System.Drawing.Point(141, 259);
            this.gbValuta.Name = "gbValuta";
            this.gbValuta.Size = new System.Drawing.Size(100, 61);
            this.gbValuta.TabIndex = 23;
            this.gbValuta.TabStop = false;
            // 
            // rdbDolari
            // 
            this.rdbDolari.AutoSize = true;
            this.rdbDolari.Location = new System.Drawing.Point(25, 40);
            this.rdbDolari.Name = "rdbDolari";
            this.rdbDolari.Size = new System.Drawing.Size(52, 17);
            this.rdbDolari.TabIndex = 2;
            this.rdbDolari.TabStop = true;
            this.rdbDolari.Text = "Dolari";
            this.rdbDolari.UseVisualStyleBackColor = true;
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Location = new System.Drawing.Point(53, 17);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(47, 17);
            this.rdbEuro.TabIndex = 1;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "Euro";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // rdbRon
            // 
            this.rdbRon.AutoSize = true;
            this.rdbRon.Location = new System.Drawing.Point(3, 16);
            this.rdbRon.Name = "rdbRon";
            this.rdbRon.Size = new System.Drawing.Size(45, 17);
            this.rdbRon.TabIndex = 0;
            this.rdbRon.TabStop = true;
            this.rdbRon.Text = "Ron";
            this.rdbRon.UseVisualStyleBackColor = true;
            // 
            // dgwDate
            // 
            this.dgwDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDate.Location = new System.Drawing.Point(284, 82);
            this.dgwDate.Name = "dgwDate";
            this.dgwDate.Size = new System.Drawing.Size(481, 211);
            this.dgwDate.TabIndex = 24;
            this.dgwDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDate_CellContentClick);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(402, 321);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(77, 34);
            this.btnModifica.TabIndex = 25;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(568, 321);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(77, 34);
            this.btnSalveaza.TabIndex = 26;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnBilant
            // 
            this.btnBilant.BackColor = System.Drawing.Color.DarkViolet;
            this.btnBilant.Location = new System.Drawing.Point(568, 356);
            this.btnBilant.Name = "btnBilant";
            this.btnBilant.Size = new System.Drawing.Size(77, 33);
            this.btnBilant.TabIndex = 27;
            this.btnBilant.Text = "Bilant";
            this.btnBilant.UseVisualStyleBackColor = false;
            this.btnBilant.Click += new System.EventHandler(this.btnBilant_Click);
            // 
            // lblGestiune
            // 
            this.lblGestiune.AutoSize = true;
            this.lblGestiune.Font = new System.Drawing.Font("Webdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGestiune.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGestiune.Location = new System.Drawing.Point(27, 9);
            this.lblGestiune.Name = "lblGestiune";
            this.lblGestiune.Size = new System.Drawing.Size(252, 32);
            this.lblGestiune.TabIndex = 28;
            this.lblGestiune.Text = "GESTIUNE BUGET";
            // 
            // ckbSalariu
            // 
            this.ckbSalariu.AutoSize = true;
            this.ckbSalariu.Location = new System.Drawing.Point(141, 167);
            this.ckbSalariu.Name = "ckbSalariu";
            this.ckbSalariu.Size = new System.Drawing.Size(58, 17);
            this.ckbSalariu.TabIndex = 29;
            this.ckbSalariu.Text = "Salariu";
            this.ckbSalariu.UseVisualStyleBackColor = true;
            this.ckbSalariu.CheckedChanged += new System.EventHandler(this.ckbSalariu_CheckedChanged);
            // 
            // ckbFacturi
            // 
            this.ckbFacturi.AutoSize = true;
            this.ckbFacturi.Location = new System.Drawing.Point(141, 190);
            this.ckbFacturi.Name = "ckbFacturi";
            this.ckbFacturi.Size = new System.Drawing.Size(58, 17);
            this.ckbFacturi.TabIndex = 30;
            this.ckbFacturi.Text = "Facturi";
            this.ckbFacturi.UseVisualStyleBackColor = true;
            this.ckbFacturi.CheckedChanged += new System.EventHandler(this.ckbFacturi_CheckedChanged);
            // 
            // BtnCauta
            // 
            this.BtnCauta.Location = new System.Drawing.Point(487, 321);
            this.BtnCauta.Name = "BtnCauta";
            this.BtnCauta.Size = new System.Drawing.Size(75, 34);
            this.BtnCauta.TabIndex = 31;
            this.BtnCauta.Text = "Cauta";
            this.BtnCauta.UseVisualStyleBackColor = true;
            this.BtnCauta.Click += new System.EventHandler(this.BtnCauta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(777, 498);
            this.Controls.Add(this.BtnCauta);
            this.Controls.Add(this.ckbFacturi);
            this.Controls.Add(this.ckbSalariu);
            this.Controls.Add(this.lblGestiune);
            this.Controls.Add(this.btnBilant);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.dgwDate);
            this.Controls.Add(this.gbValuta);
            this.Controls.Add(this.btnEconomii);
            this.Controls.Add(this.btnCheltuieli);
            this.Controls.Add(this.btnVenituri);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbProvenienta);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblProveninenta);
            this.Controls.Add(this.lblTip);
            this.Name = "Form1";
            this.Text = "Aplicatie venit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbValuta.ResumeLayout(false);
            this.gbValuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblProveninenta;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.TextBox tbProvenienta;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Button btnCheltuieli;
        private System.Windows.Forms.Button btnVenituri;
        private System.Windows.Forms.Button btnEconomii;
        private System.Windows.Forms.GroupBox gbValuta;
        private System.Windows.Forms.RadioButton rdbDolari;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.RadioButton rdbRon;
        private System.Windows.Forms.DataGridView dgwDate;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnBilant;
        private System.Windows.Forms.Label lblGestiune;
        private System.Windows.Forms.CheckBox ckbFacturi;
        private System.Windows.Forms.CheckBox ckbSalariu;
        private System.Windows.Forms.Button BtnCauta;
    }
}

