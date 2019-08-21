using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(this.txtNombre.Text != "" && this.txtApellido.Text != "")
            {
                Persona p = new Persona(this.txtNombre.Text, this.txtApellido.Text);

                if (PersonaDAO.Guardar(p))
                {
                    MessageBox.Show("Se agrego una persona con exito");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar a la persona");
                }
                this.txtNombre.Text = "";
                this.txtApellido.Text = "";
            }
            else
            {
                MessageBox.Show("Los campos nombre y apellido no pueden estar vacios");
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            this.lstPersonas.Items.Clear();
            List<Persona> personas = new List<Persona>();

            personas = PersonaDAO.Leer();
            for(int i = 0; i < personas.Count; i++)
            {
                this.lstPersonas.Items.Add(personas[i].ToString());
            }
        }

        private void btnLeerUno_Click(object sender, EventArgs e)
        {
            int idaux;
            Persona p;

            if(this.txtID.Text != "")
            {
                idaux = int.Parse(this.txtID.Text);
                p = PersonaDAO.Leer(idaux);
                if(p != null)
                {
                    MessageBox.Show(p.ToString(), "Persona traida por ID");
                    this.txtID.Text = "";
                }
                else
                {
                    MessageBox.Show("El id ingresado no corresponde con ninguna persona de la base de datos");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<Persona> personas = new List<Persona>();
            int idaux = 0;
            personas = PersonaDAO.Leer();

            for(int i = 0; i < personas.Count; i++)
            {
                if(string.Equals(lstPersonas.SelectedItem, personas[i].ToString()) == true)
                {
                    idaux = personas[i].Id;
                    break;
                }
            }

            if (MessageBox.Show(lstPersonas.SelectedItem + "\nRealmente desea borrar esta persona?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               if(PersonaDAO.Borrar(idaux))
               {
                    MessageBox.Show("Persona Borrada");
               }
               else
               {
                    MessageBox.Show("No se pudo borrar a la persona");
               }
            }
            else
            {
                MessageBox.Show("No se borro a la persona");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            //this.lstPersonas.SelectedIndex
        }
    }
}
