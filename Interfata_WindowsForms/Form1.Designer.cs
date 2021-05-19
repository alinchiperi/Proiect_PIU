
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
            this.lstbAfisare = new System.Windows.Forms.ListBox();
            this.btnVenituri = new System.Windows.Forms.Button();
            this.btnCheltuieli = new System.Windows.Forms.Button();
            this.btnEconomii = new System.Windows.Forms.Button();
            this.btnVenitTotal = new System.Windows.Forms.Button();
            this.tbVenitTotal = new System.Windows.Forms.TextBox();
            this.tbCheltuieliTotale = new System.Windows.Forms.TextBox();
            this.btnCheltuieliToatale = new System.Windows.Forms.Button();
            this.tbEconomiiTotale = new System.Windows.Forms.TextBox();
            this.btnEconomiiTotale = new System.Windows.Forms.Button();
            this.gbValuta = new System.Windows.Forms.GroupBox();
            this.rdbRon = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbDolari = new System.Windows.Forms.RadioButton();
            this.dgwDate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbValuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(58, 41);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(22, 13);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Tip";
            // 
            // lblProveninenta
            // 
            this.lblProveninenta.AutoSize = true;
            this.lblProveninenta.Location = new System.Drawing.Point(58, 73);
            this.lblProveninenta.Name = "lblProveninenta";
            this.lblProveninenta.Size = new System.Drawing.Size(64, 13);
            this.lblProveninenta.TabIndex = 1;
            this.lblProveninenta.Text = "Provenienta";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(58, 108);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(34, 13);
            this.lblSuma.TabIndex = 2;
            this.lblSuma.Text = "Suma";
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(57, 139);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(37, 13);
            this.lblValuta.TabIndex = 3;
            this.lblValuta.Text = "Valuta";
            // 
            // tbProvenienta
            // 
            this.tbProvenienta.Location = new System.Drawing.Point(131, 70);
            this.tbProvenienta.Name = "tbProvenienta";
            this.tbProvenienta.Size = new System.Drawing.Size(100, 20);
            this.tbProvenienta.TabIndex = 5;
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(131, 105);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(100, 20);
            this.tbSuma.TabIndex = 6;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdauga.Location = new System.Drawing.Point(248, 180);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(329, 180);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(75, 23);
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
            this.cbTip.Location = new System.Drawing.Point(131, 41);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(100, 21);
            this.cbTip.TabIndex = 11;
            // 
            // lstbAfisare
            // 
            this.lstbAfisare.FormattingEnabled = true;
            this.lstbAfisare.Location = new System.Drawing.Point(248, 27);
            this.lstbAfisare.Name = "lstbAfisare";
            this.lstbAfisare.Size = new System.Drawing.Size(392, 147);
            this.lstbAfisare.TabIndex = 13;
            this.lstbAfisare.SelectedIndexChanged += new System.EventHandler(this.lstbAfisare_SelectedIndexChanged);
            // 
            // btnVenituri
            // 
            this.btnVenituri.BackColor = System.Drawing.Color.LightGreen;
            this.btnVenituri.Location = new System.Drawing.Point(61, 315);
            this.btnVenituri.Name = "btnVenituri";
            this.btnVenituri.Size = new System.Drawing.Size(75, 23);
            this.btnVenituri.TabIndex = 14;
            this.btnVenituri.Text = "Venituri";
            this.btnVenituri.UseVisualStyleBackColor = false;
            this.btnVenituri.Click += new System.EventHandler(this.btnVenituri_Click);
            // 
            // btnCheltuieli
            // 
            this.btnCheltuieli.BackColor = System.Drawing.Color.Crimson;
            this.btnCheltuieli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheltuieli.Location = new System.Drawing.Point(156, 315);
            this.btnCheltuieli.Name = "btnCheltuieli";
            this.btnCheltuieli.Size = new System.Drawing.Size(75, 23);
            this.btnCheltuieli.TabIndex = 15;
            this.btnCheltuieli.Text = "Cheltuieli";
            this.btnCheltuieli.UseVisualStyleBackColor = false;
            this.btnCheltuieli.Click += new System.EventHandler(this.btnCheltuieli_Click);
            // 
            // btnEconomii
            // 
            this.btnEconomii.Location = new System.Drawing.Point(60, 359);
            this.btnEconomii.Name = "btnEconomii";
            this.btnEconomii.Size = new System.Drawing.Size(75, 23);
            this.btnEconomii.TabIndex = 16;
            this.btnEconomii.Text = "Economii";
            this.btnEconomii.UseVisualStyleBackColor = true;
            this.btnEconomii.Click += new System.EventHandler(this.btnEconomii_Click);
            // 
            // btnVenitTotal
            // 
            this.btnVenitTotal.Location = new System.Drawing.Point(673, 31);
            this.btnVenitTotal.Name = "btnVenitTotal";
            this.btnVenitTotal.Size = new System.Drawing.Size(100, 23);
            this.btnVenitTotal.TabIndex = 17;
            this.btnVenitTotal.Text = "Venit Total";
            this.btnVenitTotal.UseVisualStyleBackColor = true;
            this.btnVenitTotal.Click += new System.EventHandler(this.btnVenitTotal_Click);
            // 
            // tbVenitTotal
            // 
            this.tbVenitTotal.Location = new System.Drawing.Point(673, 60);
            this.tbVenitTotal.Name = "tbVenitTotal";
            this.tbVenitTotal.Size = new System.Drawing.Size(100, 20);
            this.tbVenitTotal.TabIndex = 18;
            // 
            // tbCheltuieliTotale
            // 
            this.tbCheltuieliTotale.Location = new System.Drawing.Point(779, 60);
            this.tbCheltuieliTotale.Name = "tbCheltuieliTotale";
            this.tbCheltuieliTotale.Size = new System.Drawing.Size(100, 20);
            this.tbCheltuieliTotale.TabIndex = 20;
            // 
            // btnCheltuieliToatale
            // 
            this.btnCheltuieliToatale.Location = new System.Drawing.Point(779, 31);
            this.btnCheltuieliToatale.Name = "btnCheltuieliToatale";
            this.btnCheltuieliToatale.Size = new System.Drawing.Size(100, 23);
            this.btnCheltuieliToatale.TabIndex = 19;
            this.btnCheltuieliToatale.Text = "Cheltuieli Totale";
            this.btnCheltuieliToatale.UseVisualStyleBackColor = true;
            this.btnCheltuieliToatale.Click += new System.EventHandler(this.btnCheltuieliToatale_Click);
            // 
            // tbEconomiiTotale
            // 
            this.tbEconomiiTotale.Location = new System.Drawing.Point(885, 60);
            this.tbEconomiiTotale.Name = "tbEconomiiTotale";
            this.tbEconomiiTotale.Size = new System.Drawing.Size(100, 20);
            this.tbEconomiiTotale.TabIndex = 22;
            // 
            // btnEconomiiTotale
            // 
            this.btnEconomiiTotale.Location = new System.Drawing.Point(885, 31);
            this.btnEconomiiTotale.Name = "btnEconomiiTotale";
            this.btnEconomiiTotale.Size = new System.Drawing.Size(100, 23);
            this.btnEconomiiTotale.TabIndex = 21;
            this.btnEconomiiTotale.Text = "Economii Totale";
            this.btnEconomiiTotale.UseVisualStyleBackColor = true;
            this.btnEconomiiTotale.Click += new System.EventHandler(this.btnEconomiiTotale_Click);
            // 
            // gbValuta
            // 
            this.gbValuta.Controls.Add(this.rdbDolari);
            this.gbValuta.Controls.Add(this.rdbEuro);
            this.gbValuta.Controls.Add(this.rdbRon);
            this.gbValuta.Location = new System.Drawing.Point(131, 140);
            this.gbValuta.Name = "gbValuta";
            this.gbValuta.Size = new System.Drawing.Size(100, 61);
            this.gbValuta.TabIndex = 23;
            this.gbValuta.TabStop = false;
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
            // dgwDate
            // 
            this.dgwDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDate.Location = new System.Drawing.Point(248, 301);
            this.dgwDate.Name = "dgwDate";
            this.dgwDate.Size = new System.Drawing.Size(392, 150);
            this.dgwDate.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 587);
            this.Controls.Add(this.dgwDate);
            this.Controls.Add(this.gbValuta);
            this.Controls.Add(this.tbEconomiiTotale);
            this.Controls.Add(this.btnEconomiiTotale);
            this.Controls.Add(this.tbCheltuieliTotale);
            this.Controls.Add(this.btnCheltuieliToatale);
            this.Controls.Add(this.tbVenitTotal);
            this.Controls.Add(this.btnVenitTotal);
            this.Controls.Add(this.btnEconomii);
            this.Controls.Add(this.btnCheltuieli);
            this.Controls.Add(this.btnVenituri);
            this.Controls.Add(this.lstbAfisare);
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
        private System.Windows.Forms.ListBox lstbAfisare;
        private System.Windows.Forms.Button btnCheltuieli;
        private System.Windows.Forms.Button btnVenituri;
        private System.Windows.Forms.Button btnEconomii;
        private System.Windows.Forms.TextBox tbVenitTotal;
        private System.Windows.Forms.Button btnVenitTotal;
        private System.Windows.Forms.TextBox tbCheltuieliTotale;
        private System.Windows.Forms.Button btnCheltuieliToatale;
        private System.Windows.Forms.TextBox tbEconomiiTotale;
        private System.Windows.Forms.Button btnEconomiiTotale;
        private System.Windows.Forms.GroupBox gbValuta;
        private System.Windows.Forms.RadioButton rdbDolari;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.RadioButton rdbRon;
        private System.Windows.Forms.DataGridView dgwDate;
    }
}

