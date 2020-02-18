using SalameriaApp.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalameriaApp
{
    public partial class Form1 : Form
    {
        private int id;
        private int Conteo;
        private int Cont;
        private int CantCort;
        private int CantLar = 0;

        public Form1()
        {
            InitializeComponent();
            Conteo = 0;
            Cont = 0;
            CantCort = 0;
            CantLar = 0;
            id = 1;
        }

        private void SetTimer()
        {
            Random random = new Random();
            int timer = 0;
            timer = random.Next(100, 300);
            MyOtherTimer.Interval = timer;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private string GetDescripcion()
        {
            string descripcion = string.Empty;
            if (PrecioTextBox.Text == "100")
                descripcion = "Salami Súper Especial Tablita 500mg ";
            else
                descripcion = "Salami Súper Especial Tablita 1000mg ";
            return descripcion;
        }

        private string GetTipo()
        {
            string tipo = string.Empty;
            if (PrecioTextBox.Text == "100")
                tipo = "Corto";
            else
                tipo = "Largo";
            return tipo;
        }

        private void Agregar()
        {
            List<Salami> lista = new List<Salami>();
            if (VendidosDataGridView.DataSource != null)
            {
                lista = (List<Salami>)VendidosDataGridView.DataSource;
            }

            string Descripcion = GetDescripcion();
            string Tipo = TipoTextBox.Text;
            int Precio = ToInt(PrecioTextBox.Text);
            lista.Add(
                    new Salami(
                       salamiId: id,
                       descripcion: Descripcion,
                       tipo: Tipo,
                       precio: Precio
               ));
            id++;
            VendidosDataGridView.DataSource = null;
            VendidosDataGridView.DataSource = lista;
            LlenarValores();
        }

        private void LlenarValores()
        {
            List<Salami> lista = new List<Salami>();

            if (VendidosDataGridView.DataSource != null)
            {
                lista = (List<Salami>)VendidosDataGridView.DataSource;
            }

            int Cantidad = lista.Count;
            int DineroCort = 0;
            int DineroLar = 0;
            int Precio = 0;
            string Tipo;
            string desc = string.Empty;
            foreach (var item in lista)
            {
                Precio = item.Precio;
            }

            if (TipoTextBox.Text == "Corto")
                CantCort++;
            else if (TipoTextBox.Text == "Largo")
                CantLar++;

            PrecioTextBox.Text = Precio.ToString();
            CantidadCortosTextBox.Text = CantCort.ToString();
            CantidadLargosTextBox.Text = CantLar.ToString();
            DineroCortosTextBox.Text = "$ " + ToInt(CantCort * 100).ToString();
            DineroLargosTextBox.Text = "$ " + ToInt(CantLar * 200).ToString();
        }

        private void Iniciar()
        {
            int Cantidad = 1;
            int Precio = 0;
            string Tipo = "";
            Random random = new Random();
            int rand = 0;
            for (int i = 1; i <= Conteo; i++)
            {
                rand = random.Next(1, 5);
                if (rand == 2 || rand == 4)
                {
                    Tipo = "Corto";
                    Precio = 100;
                }
                if(rand == 3 || rand == 1)
                {
                    Tipo = "Largo";
                    Precio = 200;
                }

                TipoTextBox.Text = Tipo;
                PrecioTextBox.Text = Precio.ToString();
                CantidadTextBox.Text = Cantidad.ToString();

                Cantidad++;
                random = new Random();
            }
            if (Conteo == 168)
            {
                int Cortos = ToInt(CantidadCortosTextBox.Text);
                int Largos = ToInt(CantidadLargosTextBox.Text);
                Grafico form = new Grafico(Cortos, Largos);
                form.ShowDialog();
            }
        }

        private void Contar()
        {
            Conteo++;
            if (Conteo == 24)
                DiasTextBox.Text = "1";
            else if (Conteo == 48)
                DiasTextBox.Text = "2";
            else if (Conteo == 72)
                DiasTextBox.Text = "3";
            else if (Conteo == 96)
                DiasTextBox.Text = "4";
            else if (Conteo == 120)
                DiasTextBox.Text = "5";
            else if (Conteo == 144)
                DiasTextBox.Text = "6";
            else if (Conteo == 168)
            {
                DiasTextBox.Text = "7";
                MyTimer.Enabled = false;
            }
            HoraTextBox.Text = Conteo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetTimer();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            Contar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Conteo == 168)
            {
                MyTimer.Enabled = false;
                MyOtherTimer.Enabled = false;
            }
            else
            {
                MyTimer.Enabled = true;
                MyOtherTimer.Enabled = true;
            }
        }

        private void DetenerButton_Click(object sender, EventArgs e)
        {
            MyTimer.Enabled = false;
        }

        private void HoraTextBox_TextChanged(object sender, EventArgs e)
        {
            Iniciar();
            Agregar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Cortos = ToInt(CantidadCortosTextBox.Text);
            int Largos = ToInt(CantidadLargosTextBox.Text);
            MyTimer.Enabled = false;
            if (VendidosDataGridView.DataSource == null)
            {
                MessageBox.Show("No hay valores", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Grafico form = new Grafico(Cortos, Largos);
                form.ShowDialog();

            }
        }

        private void MyOtherTimer_Tick(object sender, EventArgs e)
        {

        }

        private void ReiniciarButton_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void Reiniciar()
        {
            Conteo = 0;
            id = 0;
            CantCort = 0;
            CantLar = 0;
            HoraTextBox.Clear();
            DiasTextBox.Clear();
            PrecioTextBox.Clear();
            CantidadTextBox.Clear();
            TipoTextBox.Clear();
            VendidosDataGridView.DataSource = null;
            CantidadCortosTextBox.Clear();
            CantidadLargosTextBox.Clear();
            DineroCortosTextBox.Clear();
            DineroLargosTextBox.Clear();
            MyTimer.Dispose();
        }
    }
}
