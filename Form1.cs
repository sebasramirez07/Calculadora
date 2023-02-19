using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double numero1 = 0, numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtresultado.Text == "0")
                txtresultado.Text = "";

            txtresultado.Text += boton.Text;
        }
       
        private void btnigual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtresultado.Text);

            if(Operador== '+')
            {
                txtresultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if(Operador== '−')
            {
                txtresultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (Operador == 'X')
            {
                txtresultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (Operador == '/')
            {
                if (txtresultado.Text != "0")
                {
                    txtresultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtresultado.Text);

                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!!");
                }
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if(txtresultado.Text.Length > 1)
            {
                txtresultado.Text = txtresultado.Text.Substring(0, txtresultado.Text.Length - 1);   
            }
            else
            {
                txtresultado.Text = "0";
            }
        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            Operador = '\0';
            txtresultado.Text = "0";
        }

        private void btnborrarultimo_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "0";
        }

        private void btncoma_Click(object sender, EventArgs e)
        {
            if (!txtresultado.Text.Contains("."))
            {
                txtresultado.Text += "."; 
            }
        }

        private void clickoperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(txtresultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                txtresultado.Text = numero1.ToString();
            }
            else
            {
  
                txtresultado.Text = "0";
            }
           
        }

     
    }
}
