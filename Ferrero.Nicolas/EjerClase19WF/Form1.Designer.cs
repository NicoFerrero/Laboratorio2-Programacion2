namespace EjerClase19WF
{
    partial class frmJugador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnTraer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSerBin = new System.Windows.Forms.Button();
            this.btnDesBin = new System.Windows.Forms.Button();
            this.btnSerXML = new System.Windows.Forms.Button();
            this.btnXMLDes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(40, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(44, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Apellido";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(40, 94);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 13);
            this.lblPuesto.TabIndex = 4;
            this.lblPuesto.Text = "Puesto";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(108, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // cboPuesto
            // 
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(108, 94);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(100, 21);
            this.cboPuesto.TabIndex = 7;
            // 
            // btnTraer
            // 
            this.btnTraer.Location = new System.Drawing.Point(133, 140);
            this.btnTraer.Name = "btnTraer";
            this.btnTraer.Size = new System.Drawing.Size(75, 23);
            this.btnTraer.TabIndex = 8;
            this.btnTraer.Text = "Traer";
            this.btnTraer.UseVisualStyleBackColor = true;
            this.btnTraer.Click += new System.EventHandler(this.btnTraer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSerBin
            // 
            this.btnSerBin.Location = new System.Drawing.Point(43, 181);
            this.btnSerBin.Name = "btnSerBin";
            this.btnSerBin.Size = new System.Drawing.Size(75, 23);
            this.btnSerBin.TabIndex = 9;
            this.btnSerBin.Text = "Ser.Bin";
            this.btnSerBin.UseVisualStyleBackColor = true;
            this.btnSerBin.Click += new System.EventHandler(this.btnSerBin_Click);
            // 
            // btnDesBin
            // 
            this.btnDesBin.Location = new System.Drawing.Point(133, 181);
            this.btnDesBin.Name = "btnDesBin";
            this.btnDesBin.Size = new System.Drawing.Size(75, 23);
            this.btnDesBin.TabIndex = 10;
            this.btnDesBin.Text = "Des.Bin";
            this.btnDesBin.UseVisualStyleBackColor = true;
            this.btnDesBin.Click += new System.EventHandler(this.btnDesBin_Click);
            // 
            // btnSerXML
            // 
            this.btnSerXML.Location = new System.Drawing.Point(43, 227);
            this.btnSerXML.Name = "btnSerXML";
            this.btnSerXML.Size = new System.Drawing.Size(75, 23);
            this.btnSerXML.TabIndex = 11;
            this.btnSerXML.Text = "Ser.XML";
            this.btnSerXML.UseVisualStyleBackColor = true;
            this.btnSerXML.Click += new System.EventHandler(this.btnSerXML_Click);
            // 
            // btnXMLDes
            // 
            this.btnXMLDes.Location = new System.Drawing.Point(133, 227);
            this.btnXMLDes.Name = "btnXMLDes";
            this.btnXMLDes.Size = new System.Drawing.Size(75, 23);
            this.btnXMLDes.TabIndex = 12;
            this.btnXMLDes.Text = "Des.XML";
            this.btnXMLDes.UseVisualStyleBackColor = true;
            this.btnXMLDes.Click += new System.EventHandler(this.btnXMLDes_Click);
            // 
            // frmJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnXMLDes);
            this.Controls.Add(this.btnSerXML);
            this.Controls.Add(this.btnDesBin);
            this.Controls.Add(this.btnSerBin);
            this.Controls.Add(this.btnTraer);
            this.Controls.Add(this.cboPuesto);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSave);
            this.Name = "frmJugador";
            this.Text = "Jugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnTraer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSerBin;
        private System.Windows.Forms.Button btnDesBin;
        private System.Windows.Forms.Button btnSerXML;
        private System.Windows.Forms.Button btnXMLDes;
    }
}

