using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesClase07;

namespace EjerClase07WF
{
    public partial class frmEquipo : Form
    {
        public frmEquipo()
        {
            InitializeComponent();
        }

        private Equipo _equipo;

        

        private void Agregar()
        {
            lstJugadores.Items.Clear();
            for (int i = 0; i < this._equipo.GetJugadores().Count; i++)
            {
                this.lstJugadores.Items.Add(this._equipo.GetJugadores()[i].MostrarDatos());
            }
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            short cantidad = short.Parse(txtCantidadJugadores.Text);

            this._equipo = new Equipo(cantidad, nombre);

            this.txtNombre.Enabled = false;
            this.txtCantidadJugadores.Enabled = false;

            this.btnAceptar.Visible = false;
            this.btnCancelar.Visible = false;

            this.lstJugadores.Visible = true;
            this.btnAgregar.Visible = true;
            this.btnSustraer.Visible = true;
            this.btnModificar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmJugador miFormulario = new frmJugador();
            miFormulario.ShowDialog();
            if (miFormulario.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (this._equipo + miFormulario.GetJugador())
                {
                    MessageBox.Show("Se agrego exitosamente");
                    this.Agregar();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar");
                }
            }
        }

        private void btnSustraer_Click(object sender, EventArgs e)
        {
            frmJugador miFormulario = new frmJugador();
            DialogResult rta = DialogResult.No;
            int index = lstJugadores.SelectedIndex;
            if (index > -1)
            {
                rta = MessageBox.Show("Realmente desea eliminar este jugador?" + "\n" + this._equipo.GetJugadores()[index].MostrarDatos(), "Borrado de jugador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ((this._equipo - this._equipo.GetJugadores()[index]) && (rta == DialogResult.Yes))
                {
                    MessageBox.Show("Jugador borrado");
                    this.Agregar();
                }
            }     
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = lstJugadores.SelectedIndex;
            if (index > -1)
            {
                frmJugador Jugador = new frmJugador(this._equipo.GetJugadores()[index]);
                Jugador.ShowDialog();
                if (Jugador.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    this._equipo.GetJugadores()[index] = Jugador.GetJugador();
                    MessageBox.Show("Jugador modificado con exito");
                    this.Agregar();
                }
            }
        }
    }
}
