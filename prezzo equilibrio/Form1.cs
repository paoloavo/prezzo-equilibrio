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
            try
            {
                // =====================
                // LETTURA INPUT
                // =====================
                double domA = double.Parse(txtDomA.Text);
                double domB = double.Parse(txtDomB.Text);

                double offA = double.Parse(txtOffA.Text);
                double offB = double.Parse(txtOffB.Text);

                double maxQ = double.Parse(txtMaxQ.Text);

                // =====================
                // PULIZIE
                // =====================
                dgvValori.Rows.Clear();
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();

                ChartArea area = new ChartArea("area");
                area.AxisX.Title = "Quantità (Q)";
                area.AxisY.Title = "Prezzo";
                area.AxisX.MajorGrid.LineColor = Color.LightGray;
                area.AxisY.MajorGrid.LineColor = Color.LightGray;
                area.AxisX.LineWidth = 2;
                area.AxisY.LineWidth = 2;

                chart1.ChartAreas.Add(area);

                Series sDom = new Series("Domanda");
                sDom.ChartType = SeriesChartType.Line;
                sDom.BorderWidth = 2;
                sDom.Color = Color.Blue;

                Series sOff = new Series("Offerta");
                sOff.ChartType = SeriesChartType.Line;
                sOff.BorderWidth = 2;
                sOff.Color = Color.Green;

                chart1.Series.Add(sDom);
                chart1.Series.Add(sOff);

                double equilibrioQ = -1;
                double equilibrioP = -1;
                double minDiff = double.MaxValue;

                double step = 0.001; // passo 0.001 per calcolo e tabella (3 decimali)

                // =====================
                // CALCOLO E POPOLAMENTO TABELLA + GRAFICO GENERALE
                // =====================
                for (double q = 0; q <= maxQ; q += step)
                {
                    double domanda = domA - domB * q;
                    double offerta = offA + Math.Pow(q, 3) / offB;

                    // tabella con 3 decimali
                    dgvValori.Rows.Add(q.ToString("0.000"), domanda.ToString("0.000"), offerta.ToString("0.000"));

                    // grafico
                    sDom.Points.AddXY(q, domanda);
                    sOff.Points.AddXY(q, offerta);

                    // equilibrio
                    double diff = Math.Abs(domanda - offerta);
                    if (diff < minDiff)
                    {
                        minDiff = diff;
                        equilibrioQ = Math.Round(q, 3);
                        equilibrioP = Math.Round((domanda + offerta) / 2.0, 3);
                    }
                }

                // =====================
                // GRAFICO DETTAGLIATO INTORNO AL PUNTO DI EQUILIBRIO
                // =====================
                if (equilibrioQ >= 0)
                {
                    double range = 0.05;       // intervallo intorno all'equilibrio
                    double stepDettaglio = 0.001; // passo fine 3 decimali

                    Series sDomEq = new Series("Domanda Dettaglio");
                    sDomEq.ChartType = SeriesChartType.Line;
                    sDomEq.BorderWidth = 2;
                    sDomEq.Color = Color.DarkBlue;

                    Series sOffEq = new Series("Offerta Dettaglio");
                    sOffEq.ChartType = SeriesChartType.Line;
                    sOffEq.BorderWidth = 2;
                    sOffEq.Color = Color.DarkGreen;

                    for (double q = Math.Max(0, equilibrioQ - range); q <= equilibrioQ + range; q += stepDettaglio)
                    {
                        double domanda = domA - domB * q;
                        double offerta = offA + Math.Pow(q, 3) / offB;

                        sDomEq.Points.AddXY(Math.Round(q, 3), Math.Round(domanda, 3));
                        sOffEq.Points.AddXY(Math.Round(q, 3), Math.Round(offerta, 3));
                    }

                    chart1.Series.Add(sDomEq);
                    chart1.Series.Add(sOffEq);

                    // =====================
                    // PUNTO DI EQUILIBRIO
                    // =====================
                    Series sEq = new Series("Equilibrio");
                    sEq.ChartType = SeriesChartType.Point;
                    sEq.MarkerStyle = MarkerStyle.Circle;
                    sEq.MarkerSize = 12;
                    sEq.Color = Color.Red;
                    sEq.Points.AddXY(equilibrioQ, equilibrioP);
                    chart1.Series.Add(sEq);

                    Series sLinea = new Series("Linea equilibrio");
                    sLinea.ChartType = SeriesChartType.Line;
                    sLinea.Color = Color.Red;
                    sLinea.BorderDashStyle = ChartDashStyle.Dash;
                    sLinea.BorderWidth = 2;
                    sLinea.Points.AddXY(equilibrioQ, 0);
                    sLinea.Points.AddXY(equilibrioQ, equilibrioP + 20);
                    chart1.Series.Add(sLinea);

                    // =====================
                    // AGGIORNA LABEL SUL FORM
                    // =====================
                    lblEquilibrioQ.Text = $"Q equilibrio = {equilibrioQ:0.000}";
                    lblEquilibrioP.Text = $"Prezzo equilibrio = {equilibrioP:0.000}";
                }
            }
            catch
            {
                MessageBox.Show("Errore: controlla che i valori numerici siano corretti.");
            }
        }
    }
}

    


