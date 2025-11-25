using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace prezzo_equilibrio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            // Parametri inseriti dall'utente
            double dOrigine = double.Parse(txtDOrigine.Text);
            double dCoeff = double.Parse(txtDCoeff.Text);

            double oCostante = double.Parse(txtOCostante.Text);
            double oCoeff = double.Parse(txtOCoeff.Text);
            double oEsponente = double.Parse(txtOEsponente.Text);

            // Pulizia grafico
            chart1.Series.Clear();

            Series domanda = new Series("Domanda");
            domanda.ChartType = SeriesChartType.Line;

            Series offerta = new Series("Offerta");
            offerta.ChartType = SeriesChartType.Line;

            // Calcolo valori per q = 0..20
            for (int q = 0; q <= 20; q++)
            {
                double dValue = dOrigine - dCoeff * q;
                double oValue = oCostante + oCoeff * Math.Pow(q, oEsponente);

                domanda.Points.AddXY(q, dValue);
                offerta.Points.AddXY(q, oValue);
            }

            chart1.Series.Add(domanda);
            chart1.Series.Add(offerta);
        }
    }
}

