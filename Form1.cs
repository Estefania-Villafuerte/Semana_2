using System;
using System.Windows.Forms;

namespace CalculadoraPaneles
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPantalla.Text += btn.Text;
        }

        private void seleccionarOperacion(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            num1 = Convert.ToDouble(txtPantalla.Text);
            operacion = btn.Text;
            txtPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double num2 = Convert.ToDouble(txtPantalla.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;
            }

            txtPantalla.Text = resultado.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }
    }
}