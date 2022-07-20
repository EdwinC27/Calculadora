using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double n1;
        private double n2;
        private double resultado;
        private int operacion;

        public Form1()
        {
            InitializeComponent();
        }

        // boton 0
        private void button0_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += "0";
        }

        // boton 1
        private void button1_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += "1";
        }

        // boton 2
        private void button2_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += "2";
        }

        // boton 3
        private void button3_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += "3";
        }

        // boton 4 
        private void button4_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += "4";
        }

        // boton 5
        private void button5_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += "5";
        }

        // boton 6
        private void button6_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += "6";
        }

        // boton 7
        private void button7_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += "7";
        }

        // boton 8
        private void button8_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += "8";
        }

        // boton 9
        private void button9_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += "9";
        }

        // Limpiar
        private void buttonQuitarTodo_Click(object sender, EventArgs e)
        {
            textVisualizar.Text = null;
        }

        // igual
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(textVisualizar.Text);

            switch (operacion)
            {
                case 1:
                    resultado = n1 + n2;
                    textVisualizar.Text = resultado.ToString();
                    break;

                case 2:
                    resultado = n1 - n2;
                    textVisualizar.Text = resultado.ToString();
                    break;

                case 3:
                    resultado = n1 * n2;
                    textVisualizar.Text = resultado.ToString();
                    break;


                case 4:
                    resultado = n1 / n2;
                    textVisualizar.Text = resultado.ToString();
                    break;
            }
        }

        // suma
        private void buttonSumar_Click(object sender, EventArgs e)
        {
            operacion = 1;

            n1 = Convert.ToDouble(textVisualizar.Text);
            textVisualizar.Text = null;
        }

        // restar
        private void buttonRestar_Click(object sender, EventArgs e)
        {
            operacion = 2;

            n1 = Convert.ToDouble(textVisualizar.Text);
            textVisualizar.Text = null;
        }

        // multiplicar
        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operacion = 3;

            n1 = Convert.ToDouble(textVisualizar.Text);
            textVisualizar.Text = null;
        }

        // dividir
        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operacion = 4;

            n1 = Convert.ToDouble(textVisualizar.Text);
            textVisualizar.Text = null;
        }

        // punto
        private void buttonPunto_Click(object sender, EventArgs e)
        {
            textVisualizar.Text += ".";
        }
    }
}
