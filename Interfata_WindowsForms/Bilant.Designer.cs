
namespace Interfata_WindowsForms
{
    partial class Bilant
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnVenitTotal = new System.Windows.Forms.Button();
            this.tbVenitTotal = new System.Windows.Forms.TextBox();
            this.tbEconomiiTotale = new System.Windows.Forms.TextBox();
            this.btnEconomiiTotale = new System.Windows.Forms.Button();
            this.tbCheltuieliTotale = new System.Windows.Forms.TextBox();
            this.btnCheltuieliToatale = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGrafic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVenitTotal
            // 
            this.btnVenitTotal.Location = new System.Drawing.Point(67, 37);
            this.btnVenitTotal.Name = "btnVenitTotal";
            this.btnVenitTotal.Size = new System.Drawing.Size(100, 23);
            this.btnVenitTotal.TabIndex = 18;
            this.btnVenitTotal.Text = "Venit Total";
            this.btnVenitTotal.UseVisualStyleBackColor = true;
            this.btnVenitTotal.Click += new System.EventHandler(this.btnVenitTotal_Click);
            // 
            // tbVenitTotal
            // 
            this.tbVenitTotal.Location = new System.Drawing.Point(67, 66);
            this.tbVenitTotal.Name = "tbVenitTotal";
            this.tbVenitTotal.Size = new System.Drawing.Size(100, 20);
            this.tbVenitTotal.TabIndex = 19;
            // 
            // tbEconomiiTotale
            // 
            this.tbEconomiiTotale.Location = new System.Drawing.Point(279, 66);
            this.tbEconomiiTotale.Name = "tbEconomiiTotale";
            this.tbEconomiiTotale.Size = new System.Drawing.Size(100, 20);
            this.tbEconomiiTotale.TabIndex = 26;
            // 
            // btnEconomiiTotale
            // 
            this.btnEconomiiTotale.Location = new System.Drawing.Point(279, 37);
            this.btnEconomiiTotale.Name = "btnEconomiiTotale";
            this.btnEconomiiTotale.Size = new System.Drawing.Size(100, 23);
            this.btnEconomiiTotale.TabIndex = 25;
            this.btnEconomiiTotale.Text = "Economii Totale";
            this.btnEconomiiTotale.UseVisualStyleBackColor = true;
            // 
            // tbCheltuieliTotale
            // 
            this.tbCheltuieliTotale.Location = new System.Drawing.Point(173, 66);
            this.tbCheltuieliTotale.Name = "tbCheltuieliTotale";
            this.tbCheltuieliTotale.Size = new System.Drawing.Size(100, 20);
            this.tbCheltuieliTotale.TabIndex = 24;
            // 
            // btnCheltuieliToatale
            // 
            this.btnCheltuieliToatale.Location = new System.Drawing.Point(173, 37);
            this.btnCheltuieliToatale.Name = "btnCheltuieliToatale";
            this.btnCheltuieliToatale.Size = new System.Drawing.Size(100, 23);
            this.btnCheltuieliToatale.TabIndex = 23;
            this.btnCheltuieliToatale.Text = "Cheltuieli Totale";
            this.btnCheltuieliToatale.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(399, 37);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Venituri";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Cheltuieli";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Economii";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(340, 280);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            // 
            // btnGrafic
            // 
            this.btnGrafic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGrafic.Location = new System.Drawing.Point(155, 223);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(133, 72);
            this.btnGrafic.TabIndex = 28;
            this.btnGrafic.Text = "Afisare Grafic";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // Bilant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tbEconomiiTotale);
            this.Controls.Add(this.btnEconomiiTotale);
            this.Controls.Add(this.tbCheltuieliTotale);
            this.Controls.Add(this.btnCheltuieliToatale);
            this.Controls.Add(this.tbVenitTotal);
            this.Controls.Add(this.btnVenitTotal);
            this.Name = "Bilant";
            this.Text = "Bilant";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVenitTotal;
        private System.Windows.Forms.TextBox tbVenitTotal;
        private System.Windows.Forms.TextBox tbEconomiiTotale;
        private System.Windows.Forms.Button btnEconomiiTotale;
        private System.Windows.Forms.TextBox tbCheltuieliTotale;
        private System.Windows.Forms.Button btnCheltuieliToatale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnGrafic;
    }
}