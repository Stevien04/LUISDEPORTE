namespace CapaPresentacion
{
    partial class frmCrearTorneo
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCrearTorneo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombreTorneo = new System.Windows.Forms.TextBox();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.txtCreador = new System.Windows.Forms.TextBox();
            this.lblCreador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(236, 227);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(355, 104);
            this.txtDescripcion.TabIndex = 82;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 227);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(185, 21);
            this.lblDescripcion.TabIndex = 81;
            this.lblDescripcion.Text = "Descripcion del Torneo";
            // 
            // btnCrearTorneo
            // 
            this.btnCrearTorneo.BackColor = System.Drawing.Color.LightGray;
            this.btnCrearTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTorneo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTorneo.Location = new System.Drawing.Point(236, 353);
            this.btnCrearTorneo.Name = "btnCrearTorneo";
            this.btnCrearTorneo.Size = new System.Drawing.Size(202, 45);
            this.btnCrearTorneo.TabIndex = 79;
            this.btnCrearTorneo.Text = "Crear Torneo";
            this.btnCrearTorneo.UseVisualStyleBackColor = false;
            this.btnCrearTorneo.Click += new System.EventHandler(this.btnCrearTorneo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(230, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 36);
            this.lblTitulo.TabIndex = 83;
            this.lblTitulo.Text = "CREAR TORNEO";
            // 
            // txtNombreTorneo
            // 
            this.txtNombreTorneo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtNombreTorneo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreTorneo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTorneo.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreTorneo.Location = new System.Drawing.Point(236, 182);
            this.txtNombreTorneo.Name = "txtNombreTorneo";
            this.txtNombreTorneo.Size = new System.Drawing.Size(226, 27);
            this.txtNombreTorneo.TabIndex = 77;
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEquipo.ForeColor = System.Drawing.Color.Black;
            this.lblNombreEquipo.Location = new System.Drawing.Point(57, 185);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(158, 21);
            this.lblNombreEquipo.TabIndex = 76;
            this.lblNombreEquipo.Text = "Nombre del Torneo";
            // 
            // txtCreador
            // 
            this.txtCreador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtCreador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreador.ForeColor = System.Drawing.Color.DimGray;
            this.txtCreador.Location = new System.Drawing.Point(236, 133);
            this.txtCreador.Name = "txtCreador";
            this.txtCreador.ReadOnly = true;
            this.txtCreador.Size = new System.Drawing.Size(226, 27);
            this.txtCreador.TabIndex = 80;
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreador.ForeColor = System.Drawing.Color.Black;
            this.lblCreador.Location = new System.Drawing.Point(141, 136);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(75, 21);
            this.lblCreador.TabIndex = 78;
            this.lblCreador.Text = "Creador";
            // 
            // frmCrearTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(699, 522);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnCrearTorneo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombreTorneo);
            this.Controls.Add(this.lblNombreEquipo);
            this.Controls.Add(this.txtCreador);
            this.Controls.Add(this.lblCreador);
            this.Name = "frmCrearTorneo";
            this.Text = "frmCrearTorneo";
            this.Load += new System.EventHandler(this.frmCrearTorneo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCrearTorneo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombreTorneo;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.TextBox txtCreador;
        private System.Windows.Forms.Label lblCreador;
    }
}