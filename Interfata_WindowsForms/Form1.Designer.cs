
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
            this.tbValuta = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbTip = new System.Windows.Forms.ComboBox();
            this.lstbAfisare = new System.Windows.Forms.ListBox();
            this.btnVenituri = new System.Windows.Forms.Button();
            this.btnCheltuieli = new System.Windows.Forms.Button();
            this.btnEconomii = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // tbValuta
            // 
            this.tbValuta.Location = new System.Drawing.Point(131, 136);
            this.tbValuta.Name = "tbValuta";
            this.tbValuta.Size = new System.Drawing.Size(100, 20);
            this.tbValuta.TabIndex = 7;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdauga.Location = new System.Drawing.Point(61, 244);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(156, 244);
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
            // tbTip
            // 
            this.tbTip.FormattingEnabled = true;
            this.tbTip.Items.AddRange(new object[] {
            "Venit",
            "Cheltuiala",
            "Economie"});
            this.tbTip.Location = new System.Drawing.Point(131, 41);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(100, 21);
            this.tbTip.TabIndex = 11;
            // 
            // lstbAfisare
            // 
            this.lstbAfisare.FormattingEnabled = true;
            this.lstbAfisare.Location = new System.Drawing.Point(286, 27);
            this.lstbAfisare.Name = "lstbAfisare";
            this.lstbAfisare.Size = new System.Drawing.Size(380, 186);
            this.lstbAfisare.TabIndex = 13;
            // 
            // btnVenituri
            // 
            this.btnVenituri.BackColor = System.Drawing.Color.LightGreen;
            this.btnVenituri.Location = new System.Drawing.Point(295, 244);
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
            this.btnCheltuieli.Location = new System.Drawing.Point(404, 244);
            this.btnCheltuieli.Name = "btnCheltuieli";
            this.btnCheltuieli.Size = new System.Drawing.Size(75, 23);
            this.btnCheltuieli.TabIndex = 15;
            this.btnCheltuieli.Text = "Cheltuieli";
            this.btnCheltuieli.UseVisualStyleBackColor = false;
            this.btnCheltuieli.Click += new System.EventHandler(this.btnCheltuieli_Click);
            // 
            // btnEconomii
            // 
            this.btnEconomii.Location = new System.Drawing.Point(533, 244);
            this.btnEconomii.Name = "btnEconomii";
            this.btnEconomii.Size = new System.Drawing.Size(75, 23);
            this.btnEconomii.TabIndex = 16;
            this.btnEconomii.Text = "Economii";
            this.btnEconomii.UseVisualStyleBackColor = true;
            this.btnEconomii.Click += new System.EventHandler(this.btnEconomii_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.btnEconomii);
            this.Controls.Add(this.btnCheltuieli);
            this.Controls.Add(this.btnVenituri);
            this.Controls.Add(this.lstbAfisare);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbValuta);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbProvenienta);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblProveninenta);
            this.Controls.Add(this.lblTip);
            this.Name = "Form1";
            this.Text = "Aplicatie venit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox tbValuta;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox tbTip;
        private System.Windows.Forms.ListBox lstbAfisare;
        private System.Windows.Forms.Button btnCheltuieli;
        private System.Windows.Forms.Button btnVenituri;
        private System.Windows.Forms.Button btnEconomii;
    }
}

