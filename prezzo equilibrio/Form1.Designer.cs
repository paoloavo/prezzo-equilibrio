namespace prezzo_equilibrio
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;


        private System.Windows.Forms.TextBox txtDomA;
        private System.Windows.Forms.TextBox txtDomB;
        private System.Windows.Forms.TextBox txtOffA;
        private System.Windows.Forms.TextBox txtOffB;
        private System.Windows.Forms.TextBox txtMaxQ; 
        private System.Windows.Forms.Label lblEquilibrioQ;
        private System.Windows.Forms.Label lblEquilibrioP;


        private System.Windows.Forms.Button btnCalcola;

        private System.Windows.Forms.DataGridView dgvValori;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEquilibrioQ = new System.Windows.Forms.Label();
            this.lblEquilibrioP = new System.Windows.Forms.Label();
            this.txtDomA = new System.Windows.Forms.TextBox();
            this.txtDomB = new System.Windows.Forms.TextBox();
            this.txtOffA = new System.Windows.Forms.TextBox();
            this.txtOffB = new System.Windows.Forms.TextBox();
            this.txtMaxQ = new System.Windows.Forms.TextBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.dgvValori = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domanda A:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domanda B:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Offerta A:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Offerta B:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Q:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(221, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tabella Valori / Grafico";
            // 
            // txtDomA
            // 
            this.txtDomA.Location = new System.Drawing.Point(120, 20);
            this.txtDomA.Name = "txtDomA";
            this.txtDomA.Size = new System.Drawing.Size(80, 20);
            this.txtDomA.TabIndex = 6;
            this.txtDomA.Text = "90";
            // 
            // txtDomB
            // 
            this.txtDomB.Location = new System.Drawing.Point(120, 60);
            this.txtDomB.Name = "txtDomB";
            this.txtDomB.Size = new System.Drawing.Size(80, 20);
            this.txtDomB.TabIndex = 7;
            this.txtDomB.Text = "4";
            // 
            // txtOffA
            // 
            this.txtOffA.Location = new System.Drawing.Point(120, 100);
            this.txtOffA.Name = "txtOffA";
            this.txtOffA.Size = new System.Drawing.Size(80, 20);
            this.txtOffA.TabIndex = 8;
            this.txtOffA.Text = "10";
            // 
            // txtOffB
            // 
            this.txtOffB.Location = new System.Drawing.Point(120, 140);
            this.txtOffB.Name = "txtOffB";
            this.txtOffB.Size = new System.Drawing.Size(80, 20);
            this.txtOffB.TabIndex = 9;
            this.txtOffB.Text = "100";
            // 
            // txtMaxQ
            // 
            this.txtMaxQ.Location = new System.Drawing.Point(120, 180);
            this.txtMaxQ.Name = "txtMaxQ";
            this.txtMaxQ.Size = new System.Drawing.Size(80, 20);
            this.txtMaxQ.TabIndex = 10;
            this.txtMaxQ.Text = "15";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(20, 215);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(180, 35);
            this.btnCalcola.TabIndex = 11;
            this.btnCalcola.Text = "Calcola e Disegna";
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // dgvValori
            // 
            this.dgvValori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvValori.Location = new System.Drawing.Point(20, 260);
            this.dgvValori.Name = "dgvValori";
            this.dgvValori.Size = new System.Drawing.Size(350, 300);
            this.dgvValori.TabIndex = 12;

            this.lblEquilibrioQ.Location = new System.Drawing.Point(20, 570);
            this.lblEquilibrioQ.Size = new System.Drawing.Size(250, 23);
            this.lblEquilibrioQ.Text = "Q equilibrio = ";
            this.lblEquilibrioQ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // lblEquilibrioP
            this.lblEquilibrioP.Location = new System.Drawing.Point(300, 570);
            this.lblEquilibrioP.Size = new System.Drawing.Size(250, 23);
            this.lblEquilibrioP.Text = "Prezzo equilibrio = ";
            this.lblEquilibrioP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(400, 20);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(700, 540);
            this.chart1.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDomA);
            this.Controls.Add(this.txtDomB);
            this.Controls.Add(this.txtOffA);
            this.Controls.Add(this.txtOffB);
            this.Controls.Add(this.txtMaxQ);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.dgvValori);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblEquilibrioQ);
            this.Controls.Add(this.lblEquilibrioP);
            this.Name = "Form1";
            this.Text = "Curve Domanda e Offerta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvValori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
    
}

      

