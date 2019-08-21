using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesClase19;
using System.IO;

namespace EjerClase19WF
{
    public partial class frmJugador : Form
    {
        public frmJugador()
        {
            InitializeComponent();

            foreach(EPuesto item in Enum.GetValues(typeof(EPuesto)))
            {
                this.cboPuesto.Items.Add(item);
            }
            this.cboPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboPuesto.SelectedItem = EPuesto.Arquero;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Jugador j = new Jugador(txtName.Text, txtLastName.Text, ((EPuesto)(cboPuesto.SelectedItem)));
            string linea = "";
            string path = ""; 
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\jugadores.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = saveFileDialog1.FileNames[0];
            }

            /*StreamWriter escritura = new StreamWriter(@"D:\jugadores.txt", true);
            //StreamWriter escritura = new StreamWriter("D:\\jugadores.txt");
            escritura.WriteLine(j.ToString());
            escritura.Close();

            StreamReader lectura = new StreamReader(@"D:\jugadores.txt");
            while((linea = lectura.ReadLine()) != null)
            {
                MessageBox.Show(linea);
            }
            //MessageBox.Show(lectura.ReadToEnd());
            lectura.Close();

            //MessageBox.Show(j.ToString());*/

            AdministradorDeArchivos.Escribir(path, j.ToString(), true);

            if (AdministradorDeArchivos.Leer(path, out linea) == true)
            {
                MessageBox.Show(linea);
            }  
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            string path = "";
            Jugador j = new Jugador(txtName.Text, txtLastName.Text, ((EPuesto)(cboPuesto.SelectedItem)));
            Jugador j1;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog1.FileNames[0];
            }

            if (Jugador.TraerUno(path, j, out j1) == true)
            {
                txtName.Text = "";
                txtLastName.Text = "";
                MessageBox.Show("Buscando Jugador");
                txtName.Text = j1.Nombre;
                txtLastName.Text = j1.Apellido;
                cboPuesto.SelectedValue = j1.Puesto;
                MessageBox.Show("Jugador Encontrado");
            }
            else
            {
                MessageBox.Show("Jugador no encontrado");
            }
        }

        private void btnSerBin_Click(object sender, EventArgs e)
        {
            Jugador j = new Jugador("Nico", "Ferrero", EPuesto.Medio);
            ((ISerializableBinario)j).Serializar();
        }

        private void btnDesBin_Click(object sender, EventArgs e)
        {
            Jugador nuevoJugador = new Jugador("Nico", "Ferrero", EPuesto.Medio);
            Jugador j = ((ISerializableBinario)nuevoJugador).Deserializar();

            MessageBox.Show(j.ToString());
        }

        private void btnSerXML_Click(object sender, EventArgs e)
        {
            Jugador j = new Jugador("Nico", "Ferrero", EPuesto.Medio);
            ((ISerializableXML)j).Serializar();
        }

        private void btnXMLDes_Click(object sender, EventArgs e)
        {
            Jugador nuevoJugador = new Jugador("Nico", "Ferrero", EPuesto.Medio);
            Jugador j = ((ISerializableXML)nuevoJugador).Deserializar();

            MessageBox.Show(j.ToString());
        }
    }
}
