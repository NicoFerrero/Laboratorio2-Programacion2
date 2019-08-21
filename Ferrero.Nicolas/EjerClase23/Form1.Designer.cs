namespace EjerClase23
{
    partial class frmCajeroAutomatico
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
            this.lblRetirar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.txtPesosDos = new System.Windows.Forms.TextBox();
            this.lblPesosDos = new System.Windows.Forms.Label();
            this.lblPesosCinco = new System.Windows.Forms.Label();
            this.txtPesosCinco = new System.Windows.Forms.TextBox();
            this.txtPesosDiez = new System.Windows.Forms.TextBox();
            this.lblPesosDiez = new System.Windows.Forms.Label();
            this.lblPesosVeinte = new System.Windows.Forms.Label();
            this.txtPesosVeinte = new System.Windows.Forms.TextBox();
            this.lblPesosCincuenta = new System.Windows.Forms.Label();
            this.txtPesosCincuenta = new System.Windows.Forms.TextBox();
            this.lblPesosCien = new System.Windows.Forms.Label();
            this.txtPesosCien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRetirar
            // 
            this.lblRetirar.AutoSize = true;
            this.lblRetirar.Location = new System.Drawing.Point(12, 21);
            this.lblRetirar.Name = "lblRetirar";
            this.lblRetirar.Size = new System.Drawing.Size(87, 13);
            this.lblRetirar.TabIndex = 0;
            this.lblRetirar.Text = "Cantidad a retirar";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(253, 173);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(253, 69);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(253, 21);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtRetirar
            // 
            this.txtRetirar.Location = new System.Drawing.Point(105, 19);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(100, 20);
            this.txtRetirar.TabIndex = 4;
            // 
            // txtPesosDos
            // 
            this.txtPesosDos.Location = new System.Drawing.Point(105, 45);
            this.txtPesosDos.Name = "txtPesosDos";
            this.txtPesosDos.ReadOnly = true;
            this.txtPesosDos.Size = new System.Drawing.Size(100, 20);
            this.txtPesosDos.TabIndex = 5;
            // 
            // lblPesosDos
            // 
            this.lblPesosDos.AutoSize = true;
            this.lblPesosDos.Location = new System.Drawing.Point(12, 45);
            this.lblPesosDos.Name = "lblPesosDos";
            this.lblPesosDos.Size = new System.Drawing.Size(70, 13);
            this.lblPesosDos.TabIndex = 6;
            this.lblPesosDos.Text = "Billetes de $2";
            // 
            // lblPesosCinco
            // 
            this.lblPesosCinco.AutoSize = true;
            this.lblPesosCinco.Location = new System.Drawing.Point(12, 69);
            this.lblPesosCinco.Name = "lblPesosCinco";
            this.lblPesosCinco.Size = new System.Drawing.Size(70, 13);
            this.lblPesosCinco.TabIndex = 7;
            this.lblPesosCinco.Text = "Billetes de $5";
            // 
            // txtPesosCinco
            // 
            this.txtPesosCinco.Location = new System.Drawing.Point(105, 71);
            this.txtPesosCinco.Name = "txtPesosCinco";
            this.txtPesosCinco.ReadOnly = true;
            this.txtPesosCinco.Size = new System.Drawing.Size(100, 20);
            this.txtPesosCinco.TabIndex = 8;
            // 
            // txtPesosDiez
            // 
            this.txtPesosDiez.Location = new System.Drawing.Point(105, 97);
            this.txtPesosDiez.Name = "txtPesosDiez";
            this.txtPesosDiez.ReadOnly = true;
            this.txtPesosDiez.Size = new System.Drawing.Size(100, 20);
            this.txtPesosDiez.TabIndex = 9;
            // 
            // lblPesosDiez
            // 
            this.lblPesosDiez.AutoSize = true;
            this.lblPesosDiez.Location = new System.Drawing.Point(12, 97);
            this.lblPesosDiez.Name = "lblPesosDiez";
            this.lblPesosDiez.Size = new System.Drawing.Size(76, 13);
            this.lblPesosDiez.TabIndex = 10;
            this.lblPesosDiez.Text = "Billetes de $10";
            // 
            // lblPesosVeinte
            // 
            this.lblPesosVeinte.AutoSize = true;
            this.lblPesosVeinte.Location = new System.Drawing.Point(12, 125);
            this.lblPesosVeinte.Name = "lblPesosVeinte";
            this.lblPesosVeinte.Size = new System.Drawing.Size(76, 13);
            this.lblPesosVeinte.TabIndex = 12;
            this.lblPesosVeinte.Text = "Billetes de $20";
            // 
            // txtPesosVeinte
            // 
            this.txtPesosVeinte.Location = new System.Drawing.Point(105, 123);
            this.txtPesosVeinte.Name = "txtPesosVeinte";
            this.txtPesosVeinte.ReadOnly = true;
            this.txtPesosVeinte.Size = new System.Drawing.Size(100, 20);
            this.txtPesosVeinte.TabIndex = 11;
            // 
            // lblPesosCincuenta
            // 
            this.lblPesosCincuenta.AutoSize = true;
            this.lblPesosCincuenta.Location = new System.Drawing.Point(12, 152);
            this.lblPesosCincuenta.Name = "lblPesosCincuenta";
            this.lblPesosCincuenta.Size = new System.Drawing.Size(76, 13);
            this.lblPesosCincuenta.TabIndex = 14;
            this.lblPesosCincuenta.Text = "Billetes de $50";
            // 
            // txtPesosCincuenta
            // 
            this.txtPesosCincuenta.Location = new System.Drawing.Point(105, 152);
            this.txtPesosCincuenta.Name = "txtPesosCincuenta";
            this.txtPesosCincuenta.ReadOnly = true;
            this.txtPesosCincuenta.Size = new System.Drawing.Size(100, 20);
            this.txtPesosCincuenta.TabIndex = 13;
            // 
            // lblPesosCien
            // 
            this.lblPesosCien.AutoSize = true;
            this.lblPesosCien.Location = new System.Drawing.Point(12, 178);
            this.lblPesosCien.Name = "lblPesosCien";
            this.lblPesosCien.Size = new System.Drawing.Size(82, 13);
            this.lblPesosCien.TabIndex = 16;
            this.lblPesosCien.Text = "Billetes de $100";
            // 
            // txtPesosCien
            // 
            this.txtPesosCien.Location = new System.Drawing.Point(105, 178);
            this.txtPesosCien.Name = "txtPesosCien";
            this.txtPesosCien.ReadOnly = true;
            this.txtPesosCien.Size = new System.Drawing.Size(100, 20);
            this.txtPesosCien.TabIndex = 15;
            // 
            // frmCajeroAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 213);
            this.Controls.Add(this.lblPesosCien);
            this.Controls.Add(this.txtPesosCien);
            this.Controls.Add(this.lblPesosCincuenta);
            this.Controls.Add(this.txtPesosCincuenta);
            this.Controls.Add(this.lblPesosVeinte);
            this.Controls.Add(this.txtPesosVeinte);
            this.Controls.Add(this.lblPesosDiez);
            this.Controls.Add(this.txtPesosDiez);
            this.Controls.Add(this.txtPesosCinco);
            this.Controls.Add(this.lblPesosCinco);
            this.Controls.Add(this.lblPesosDos);
            this.Controls.Add(this.txtPesosDos);
            this.Controls.Add(this.txtRetirar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRetirar);
            this.Name = "frmCajeroAutomatico";
            this.Text = "Cajero Automatico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetirar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtRetirar;
        private System.Windows.Forms.TextBox txtPesosDos;
        private System.Windows.Forms.Label lblPesosDos;
        private System.Windows.Forms.Label lblPesosCinco;
        private System.Windows.Forms.TextBox txtPesosCinco;
        private System.Windows.Forms.TextBox txtPesosDiez;
        private System.Windows.Forms.Label lblPesosDiez;
        private System.Windows.Forms.Label lblPesosVeinte;
        private System.Windows.Forms.TextBox txtPesosVeinte;
        private System.Windows.Forms.Label lblPesosCincuenta;
        private System.Windows.Forms.TextBox txtPesosCincuenta;
        private System.Windows.Forms.Label lblPesosCien;
        private System.Windows.Forms.TextBox txtPesosCien;

    }
}

