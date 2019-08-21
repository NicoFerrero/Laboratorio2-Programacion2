using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerClase23
{
    public partial class frmCajeroAutomatico : Form
    {
        public frmCajeroAutomatico()
        {
            InitializeComponent();
            this.btnAceptar.Click += new EventHandler(Calcular);
        }

        private void Calcular(object sender, EventArgs e)
        {
            int retirar = 0;   
            int resto = 0;

            if (this.txtRetirar.Text != "")
            {
                retirar = int.Parse(this.txtRetirar.Text);
            }

            if(retirar % 2 != 0 && retirar % 5 != 0)
            {
                retirar -= 1;
                resto += 1;
            }

            int cien = 0;
            int cincuenta = 0;
            int veinte = 0;
            int diez = 0;
            int cinco = 0;
            int dos = 0;

            while (retirar > 0)
            {
                if (retirar % 100 == 0)
                {
                    cien++;
                    retirar -= 100;
                }
                else if (retirar % 50 == 0)
                {
                    cincuenta++;
                    retirar -= 50;
                }
                else if ((((retirar - 20) % 50) == 0) || (((retirar - 40) % 50) == 0))
                {
                    veinte++;
                    retirar -= 20;
                }
                else if ((((retirar - 10) % 20) == 0) || (((retirar - 30) % 50) == 0))
                {
                    diez++;
                    retirar -= 10;
                }
                else if (retirar % 5 == 0)
                {
                    cinco++;
                    retirar -= 5;
                }
                else if (retirar % 2 == 0)
                {
                    dos++;
                    retirar -= 2;
                }
            }

            this.txtPesosCien.Text = cien.ToString();
            this.txtPesosCincuenta.Text = cincuenta.ToString();
            this.txtPesosVeinte.Text = veinte.ToString();
            this.txtPesosDiez.Text = diez.ToString();
            this.txtPesosCinco.Text = cinco.ToString();
            this.txtPesosDos.Text = dos.ToString();

            if (resto < 2 && resto > 0)
            {
                MessageBox.Show("El resto es " + resto);
            }
                
            this.btnAceptar.Click -= new EventHandler(Calcular);
            this.btnAceptar.Click += new EventHandler(Informar);
            this.btnLimpiar.Click += new EventHandler(Limpiar);
        }

        private void Limpiar(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void Informar(object sender, EventArgs e)
        {
            MessageBox.Show("Debe limpar la pantalla antes de seguir operando");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.btnLimpiar.Click -= new EventHandler(Limpiar);
            this.btnAceptar.Click -= new EventHandler(Informar);
            this.btnAceptar.Click += new EventHandler(Calcular);
        }
    }
}
