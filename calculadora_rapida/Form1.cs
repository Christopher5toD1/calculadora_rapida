using System.Data.SqlTypes;

namespace calculadora_rapida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Tx_Valor1.Text = "";
            Tx_Valor2.Text = "";
            Tx_Suma.Text = "";
            Tx_Resta.Text = "";
            Tx_Multiplicacion.Text = "";
            Tx_Division.Text = "";
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double v1, v2, r1, r2, r3, r4;

            v1 = double.Parse(Tx_Valor1.Text);
            v2 = double.Parse(Tx_Valor2.Text);
            // suma 
            r1 = v1 + v2;
            Tx_Suma.Text = r1.ToString();
            // resta
            r2 = v1 - v2;
            Tx_Resta.Text = r2.ToString();
            // division
            r4 = v1 / v2;
            Tx_Division.Text = r4.ToString();
            // multiplicacion
            r3 = v1 * v2;
            Tx_Multiplicacion.Text = r3.ToString();



        }

        private void Salir_Click(object sender, EventArgs e)
        {
           this.Close();
       
    }
    }
}
