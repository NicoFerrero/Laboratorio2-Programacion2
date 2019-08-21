using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesClase24;

namespace EjerClase24WF
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        public void ManejadorEvento()
        {
            MessageBox.Show("El sueldo no puede ser cero");
        }

        public void ManejadorEvento2(double sueldo, Empleado e)
        {
            MessageBox.Show("(LIMITE 10000) El empleado " + e.ToString() + " quiere cobrar " + sueldo);
        }

        public void ManejadorEvento3(Empleado sender, EmpleadoEventArgs e)
        {
            MessageBox.Show("(ENTRE 20000 Y 30000) El empleado " + sender.ToString() + " quiere cobrar " + e.Sueldo);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtDNI.Text != "" && txtSueldo.Text != "")
            {
                Empleado empleado = new Empleado(txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text));
                empleado.SueldoCero += new DelegadoSueldoCero(ManejadorEvento);
                empleado.SueldoMaximo += new DelegadoLimiteSueldo(ManejadorEvento2);
                empleado.SueldoMaximoMejorado += new DelegadoLimiteSueldoMejorado(ManejadorEvento3);

                try
                {
                    empleado.Sueldo = double.Parse(txtSueldo.Text);
                }
                catch (SueldoNegativoException ex)
                {
                    MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show(empleado.ToString());
            }
        }
    }
}
