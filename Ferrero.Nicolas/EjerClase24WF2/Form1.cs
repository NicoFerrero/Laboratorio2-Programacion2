using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerClase24WF2
{
    public delegate void miDelegado(string mensaje);

    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public miDelegado Actualizar;

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados delegados = new frmTestDelegados();
            delegados.Show(this);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos datos = new frmDatos();
            datos.Show(this);
            Actualizar = new miDelegado(datos.ActualizarNombre);
        }
    }
}
