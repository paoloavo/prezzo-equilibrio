namespace prezzo_equilibrio
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDOrigine;
        private System.Windows.Forms.TextBox txtDCoeff;
        private System.Windows.Forms.TextBox txtOCostante;
        private System.Windows.Forms.TextBox txtOCoeff;
        private System.Windows.Forms.TextBox txtOEsponente;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.txtDOrigine = new System.Windows.Forms.TextBox();
            this.txtDCoeff = new System.Windows.Forms.TextBox();
            this.txtOCostante = new System.Windows.Forms.TextBox();
            this.txtOCoeff = new System.Windows.Forms.TextBox();
            this.txtOEsponente = new System.Windows.Forms.TextBox();

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();

            this.btnCalcola = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();

            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();

            // ------------------- LABELS -------------------
            this.label1.Text = "Domanda - Origine:";
            this.label1.Location = new System.Drawing.Point(20, 20);

            this.label2.Text = "Domanda - Coeff:";
            this.label2.Location = new System.Drawing.Point(20, 60);

            this.label3.Text = "Offerta - Costante:";
            this.label3.Location = new System.Drawing.Point(250, 20);

            this.label4.Text = "Offerta - Coeff:";
            this.label4.Location = new System.Drawing.Point(250, 60);

            this.label5.Text = "Offerta - Esponente:";
            this.label5.Location = new System.Drawing.Point(250, 100);

            // ------------------- TEXTBOX -------------------
            this.txtDOrigine.Location = new System.Drawing.Point(150, 20);
            this.txtDOrigine.Size = new System.Drawing.Size(70, 23);
            this.txtDOrigine.Text = "90";

            this.txtDCoeff.Location = new System.Drawing.Point(150, 60);
            this.txtDCoeff.Size = new System.Drawing.Size(70, 23);
            this.txtDCoeff.Text = "4";

            this.txtOCostante.Location = new System.Drawing.Point(370, 20);
            this.txtOCostante.Size = new System.Drawing.Size(70, 23);
            this.txtOCostante.Text = "10";

            this.txtOCoeff.Location = new System.Drawing.Point(370, 60);
            this.txtOCoeff.Size = new System.Drawing.Size(70, 23);
            this.txtOCoeff.Text = "0.01";

            this.txtOEsponente.Location = new System.Drawing.Point(370, 100);
            this.txtOEsponente.Size = new System.Drawing.Size(70, 23);
            this.txtOEsponente.Text = "3";

            // ------------------- BOTTONE -------------------
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.Location = new System.Drawing.Point(20, 100);
            this.btnCalcola.Size = new System.Drawing.Size(200, 35);
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);

            // ------------------- CHART -------------------
            this.chart1.Location = new System.Drawing.Point(20, 150);
            this.chart1.Size = new System.Drawing.Size(600, 350);

            // ------------------- FORM -------------------
            this.ClientSize = new System.Drawing.Size(650, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);

            this.Controls.Add(this.txtDOrigine);
            this.Controls.Add(this.txtDCoeff);
            this.Controls.Add(this.txtOCostante);
            this.Controls.Add(this.txtOCoeff);
            this.Controls.Add(this.txtOEsponente);

            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.chart1);

            this.Text = "Domanda e Offerta";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

      

