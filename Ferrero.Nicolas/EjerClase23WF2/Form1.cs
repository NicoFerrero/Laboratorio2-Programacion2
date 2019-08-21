using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerClase23WF2
{
    public partial class frmCalculadora : Form
    {
        private int num1 = 0;
        private int num2 = 0;
        private string operacion = "";

        public frmCalculadora()
        {
            InitializeComponent();
            foreach(Button b in this.pnNumeros.Controls)
            {
                b.Click += new EventHandler(ManejadorCentral);
            }
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            foreach (Button b in this.pnNumeros.Controls)
            {
                if(button == b)
                {
                    foreach (Button op in this.pnOperaciones.Controls)
                    {
                        op.Click += new EventHandler(ManejadorCentral);
                    }

                    foreach (Button but in this.pnNumeros.Controls)
                    {
                        but.Click -= new EventHandler(ManejadorCentral);
                    }
                }
            }

            foreach (Button op in this.pnOperaciones.Controls)
            {
                if (op == button && button != this.btnResultado)
                {
                    num1 = int.Parse(this.txtResultado.Text);
                    operacion = button.Text;
                    this.txtResultado.Text = "";

                    foreach (Button but in this.pnNumeros.Controls)
                    {
                        but.Click += new EventHandler(ManejadorCentral);
                    }

                    foreach (Button oper in this.pnOperaciones.Controls)
                    {
                        oper.Click -= new EventHandler(ManejadorCentral);
                    }
                }
            }            
                
            if (button == this.btnResultado)
            {
                num2 = int.Parse(this.txtResultado.Text);
                this.txtResultado.Text = "";
                this.txtResultado.Text = frmCalculadora.Calcular(num1, num2, operacion);

                foreach (Button op in this.pnOperaciones.Controls)
                {
                    op.Click -= new EventHandler(ManejadorCentral);
                }

                foreach (Button but in this.pnNumeros.Controls)
                {
                    but.Click += new EventHandler(ManejadorCentral);
                }
            }
        }

        private static string Calcular(int a, int b, string op)
        {
            int resultado = 0;

            switch (op)
            {
                case "+" :
                    resultado = a + b;
                    break;

                case "-":
                    resultado = a - b;
                    break;

                case "*":
                    resultado = a * b;
                    break;

                case "/":
                    try
                    {
                        resultado = a / b;
                    }
                    catch (DivideByZeroException e)
                    {
                        //Console.WriteLine(e.ToString());
                        MessageBox.Show(e.Message);
                    }
                    break;
            }

            return resultado.ToString();
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text += "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text += "9";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text = "";
            num1 = 0;
            num2 = 0;
            operacion = "";
        }
    }
}
