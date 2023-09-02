using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caso1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void N1_TextChanged(object sender, EventArgs e)
        {

        }

        private void N2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void R_TextChanged(object sender, EventArgs e)
        {

        }

        private void Division_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if (double.TryParse(N1.Text, out numero1) && double.TryParse(N2.Text, out numero2))
            {
                if (numero2 != 0)
                {
                    double resultado = numero1 / numero2;
                    R.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero. Por favor, ingrese un valor distinto de cero en N2.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos en N1 y N2.");
            }
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            
            double numero1, numero2;

            if (double.TryParse(N1.Text, out numero1) && double.TryParse(N2.Text, out numero2))
            {
                
                double resultado = numero1 + numero2;

                
                R.Text = resultado.ToString();
            }
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if (double.TryParse(N1.Text, out numero1) && double.TryParse(N2.Text, out numero2))
            {
                double resultado = numero1 - numero2;
                R.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos en N1 y N2.");
            }
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if (double.TryParse(N1.Text, out numero1) && double.TryParse(N2.Text, out numero2))
            {
                double resultado = numero1 * numero2;
                R.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos en N1 y N2.");
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            N1.Text = "";
            N2.Text = "";
            R.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void C_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(C.Text))
            {
                
                if (decimal.TryParse(C.Text, out decimal celsius))
                {
                    
                    decimal fahrenheit = (celsius * 9 / 5) + 32;

                    
                    F.Text = fahrenheit.ToString();
                }
            }
        }
        private void F_TextChanged(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(F.Text))
                {
                   
                    if (decimal.TryParse(F.Text, out decimal fahrenheit))
                    {
                        
                        decimal celsius = (fahrenheit - 32) * 5 / 9;

                       
                        C.Text = celsius.ToString();
                    }
                }
        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            
        }

        private void ImprimirNP_Click(object sender, EventArgs e)
        {
            // Llamamos a la función que calcula los primeros 10 números primos
            List<int> primerosPrimos = CalcularPrimos(10);

            // Mostramos los números primos en el control Primos
            Primos.Text = string.Join(", ", primerosPrimos);
        }

        private List<int> CalcularPrimos(int n)
        {
            List<int> primos = new List<int>();

            int num = 2;
            while (primos.Count < n)
            {
                if (EsPrimo(num))
                {
                    primos.Add(num);
                }
                num++;
            }

            return primos;
        }

        private bool EsPrimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void Primos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
