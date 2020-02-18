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

namespace SalameriaApp
{
    public partial class Grafico : Form
    {
        private int CantCor;
        private int CantLar;

        public Grafico(int CantCortos, int CantLargos)
        {
            InitializeComponent();
            CantCor = CantCortos;
            CantLar = CantLargos;
            CantidadCortosTextBox.Text = CantCortos.ToString();
            CantidadLargosTextBox.Text = CantLargos.ToString();
        }

        private void CargarValores()
        {
            string[] series = {"Cortos","Largos"};
            int[] puntos = { CantCor, CantLar};

            ResultadosChart.Titles.Add("Salami Vendido por Tipo");
            for (int i = 0; i < series.Length; i++)
            {
                Series serie = ResultadosChart.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }

            Sugerencia();
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private void Sugerencia()
        {
            int Cortos = ToInt(CantidadCortosTextBox.Text);
            int Largos = ToInt(CantidadLargosTextBox.Text);

            if (Cortos > Largos)
            {
                int res = 0;
                res = Cortos - Largos;
                RecomendacionTextBox.Text = "Debería comprar " + res.ToString() + " Salami Súper Especial Tablita 500mg para la próxima semana";
            }
            else if (Cortos < Largos)
            {
                int res = 0;
                res = Largos - Cortos;
                RecomendacionTextBox.Text = "Debería comprar " + res.ToString() + " Salami Súper Especial Tablita 1000mg para la próxima semana";
            }
            else
                RecomendacionTextBox.Text = "Debería comprar la misma cantidad de Salami.";
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            CargarValores();
        }
    }
}
