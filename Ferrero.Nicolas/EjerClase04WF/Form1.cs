using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadCosa;

namespace EjerClase04WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int entero = int.Parse(this.txtEntero.Text);
            string cadena = this.txtCadena.Text;
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);

            Cosa cosa = new Cosa(entero, cadena, fecha);

            MessageBox.Show(cosa.Mostrar(),"Datos de la persona",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }
}
