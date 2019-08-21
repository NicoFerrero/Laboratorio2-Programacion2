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
    public partial class frmJugador : Form
    {
        public frmJugador()
        {
            InitializeComponent(); 
        }

        public frmJugador(Jugador j): this()
        {
            this._jugador = j;
            this.txtDni.Text = j.Dni.ToString();
            this.txtNombre.Text = j.Nombre;
            this.txtPartidosJugados.Text = j.PartidosJugados.ToString();
            this.txtGoles.Text = j.TotalGoles.ToString();

            this.txtDni.Enabled = false;
        }


        private Jugador _jugador;

        public Jugador GetJugador()
        {
            return this._jugador;
        }

        private void frmJugador_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            long dni = long.Parse(this.txtDni.Text);
            string nombre = this.txtNombre.Text;
            int partidosJugados = int.Parse(this.txtPartidosJugados.Text);
            int goles = int.Parse(this.txtGoles.Text);

            if ((object)this._jugador == null)
            {
                this._jugador = new Jugador(nombre, dni, goles, partidosJugados);
            }
            else
            {
                this._jugador.Nombre = this.txtNombre.Text;
                this._jugador.PartidosJugados = int.Parse(this.txtPartidosJugados.Text);
                this._jugador.TotalGoles = int.Parse(this.txtGoles.Text);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
