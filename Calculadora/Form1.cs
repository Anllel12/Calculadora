using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Autor: Angel Esquinas
 */

namespace Calculadora
{
    public partial class Form1 : Form
    {
    
        //aquí declaro las variables de instancia

        //operando1 guardará el primer número
        double operando1 = 0;
        double operando2 = 0;
        
        double resultado = 0;
        //en el string operación guardo la operación
        //que ha sido pulsada
        String operacion = "";

       

        public Form1()
        {
            InitializeComponent();
        }

        private void botonPulsado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else
            {
                label1.Text = label1.Text + boton.Text;
            }
        }

        private void operacionPulsada(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }

        private void igualPulsado(object sender, EventArgs e)
        {
            operando2 = Convert.ToDouble(label1.Text);
            

            switch (operacion)
            {
                case "+": resultado = operando1 + operando2; break;
                case "-": resultado = operando1 - operando2; break;
                case "/": resultado = operando1 / operando2; break;
                case "*": resultado = operando1 * operando2; break;
                case "sin": resultado = Math.Sin(Math.PI * operando2 / 180.0); break;
                case "cos": resultado = Math.Cos(operando2); break;
                case "tan": resultado = Math.Tan(operando2); break;
                case "log": resultado = Math.Log10(operando2); break;
                case "^3": resultado = Math.Pow(operando1, 3); break;
                case "^2": resultado = Math.Pow(operando1, 2); break;
                case "^-1": resultado = Math.Pow(operando1, -1); break;
                case "AC": operando1 = 0; operando2 = 0; break;
                case "raiz": resultado = Math.Sqrt(operando2); break;
                case "ln": resultado = Math.Log(operando2); break;
                case "^": resultado = Math.Pow(operando1, operando2); break;
                case "PI": resultado = Math.PI; break;
            }

            label1.Text = Convert.ToString(resultado);
        }
    }
}
