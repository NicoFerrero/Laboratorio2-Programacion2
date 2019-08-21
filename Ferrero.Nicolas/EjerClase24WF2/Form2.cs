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
    public partial class frmTestDelegados : Form
    {
        public frmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ((frmPrincipal)this.Owner).Actualizar(this.txtMensaje.Text); 
        }

        private void ConfigurarOpenSaveFileDialog()
        {
            this.GuardarImagen.CheckFileExists = true;
            this.GuardarImagen.DefaultExt = ".jpg";
            this.GuardarImagen.Multiselect = false;
            this.GuardarImagen.Title = "Seleccione una foto…";
            this.GuardarImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
        }

        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMensaje_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GuardarImagen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ((frmPrincipal)this.Owner).Actualizar(this.GuardarImagen.FileNames[0]);
            }
        }
    }
}
