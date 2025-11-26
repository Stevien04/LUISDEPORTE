namespace CapaPresentacion
{
    partial class frmCrearEquipo
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
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.btnCrearEquipo = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCreador = new System.Windows.Forms.Label();
            this.txtCreador = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEquipo.ForeColor = System.Drawing.Color.Black;
            this.lblNombreEquipo.Location = new System.Drawing.Point(51, 183);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(159, 21);
            this.lblNombreEquipo.TabIndex = 61;
            this.lblNombreEquipo.Text = "Nombre del Equipo";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtNombreEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEquipo.ForeColor = System.Drawing.Color.Black;
            this.txtNombreEquipo.Location = new System.Drawing.Point(230, 180);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(226, 27);
            this.txtNombreEquipo.TabIndex = 62;
            // 
            // btnCrearEquipo
            // 
            this.btnCrearEquipo.BackColor = System.Drawing.Color.LightGray;
            this.btnCrearEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEquipo.Location = new System.Drawing.Point(230, 351);
            this.btnCrearEquipo.Name = "btnCrearEquipo";
            this.btnCrearEquipo.Size = new System.Drawing.Size(202, 45);
            this.btnCrearEquipo.TabIndex = 64;
            this.btnCrearEquipo.Text = "Crear Equipo";
            this.btnCrearEquipo.UseVisualStyleBackColor = false;
            this.btnCrearEquipo.Click += new System.EventHandler(this.btnCrearEquipo_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(24, 225);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(186, 21);
            this.lblDescripcion.TabIndex = 65;
            this.lblDescripcion.Text = "Descripcion del Equipo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(230, 225);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(355, 104);
            this.txtDescripcion.TabIndex = 66;
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreador.ForeColor = System.Drawing.Color.Black;
            this.lblCreador.Location = new System.Drawing.Point(135, 134);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(75, 21);
            this.lblCreador.TabIndex = 63;
            this.lblCreador.Text = "Creador";
            // 
            // txtCreador
            // 
            this.txtCreador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtCreador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreador.ForeColor = System.Drawing.Color.Black;
            this.txtCreador.Location = new System.Drawing.Point(230, 131);
            this.txtCreador.Name = "txtCreador";
            this.txtCreador.ReadOnly = true;
            this.txtCreador.Size = new System.Drawing.Size(226, 27);
            this.txtCreador.TabIndex = 64;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(224, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 36);
            this.lblTitulo.TabIndex = 75;
            this.lblTitulo.Text = "CREAR EQUIPO";
            // 
            // frmCrearEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(699, 522);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnCrearEquipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.lblNombreEquipo);
            this.Controls.Add(this.txtCreador);
            this.Controls.Add(this.lblCreador);
            this.Name = "frmCrearEquipo";
            this.Text = "frmCrearEquipo";
            this.Load += new System.EventHandler(this.frmCrearEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.TextBox txtCreador;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCrearEquipo;
        private System.Windows.Forms.Label lblTitulo;
    }
}