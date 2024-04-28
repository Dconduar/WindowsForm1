using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCombustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

     
            btnCalcular.Click += btnCalcular_Click;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double distancia = double.Parse(txtDistancia.Text);
                double rendimiento = double.Parse(txtRendimiento.Text);

                double galonesConsumidos = distancia / rendimiento;

                lblResultado.Text = $"Cantidad de galones consumidos: {galonesConsumidos:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCalculadoraCombustible_Load(object sender, EventArgs e)
        {

        }
    }
}