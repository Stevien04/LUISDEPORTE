namespace CapaPresentacion
{
    partial class frmInvitarUsuarioEquipo
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
            this.btnInvitar = new System.Windows.Forms.Button();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.gpbUsuarioInvitado = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.gpbUsuarioInvitado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInvitar
            // 
            this.btnInvitar.Location = new System.Drawing.Point(380, 244);
            this.btnInvitar.Name = "btnInvitar";
            this.btnInvitar.Size = new System.Drawing.Size(75, 23);
            this.btnInvitar.TabIndex = 4;
            this.btnInvitar.Text = "Invitar";
            this.btnInvitar.UseVisualStyleBackColor = true;
            this.btnInvitar.Click += new System.EventHandler(this.btnInvitar_Click);
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(41, 36);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblNomUsuario.TabIndex = 0;
            this.lblNomUsuario.Text = "Nombre de Usuario";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(155, 33);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(307, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(32, 99);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(350, 76);
            this.dgvUsuario.TabIndex = 6;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // gpbUsuarioInvitado
            // 
            this.gpbUsuarioInvitado.Controls.Add(this.dgvUsuario);
            this.gpbUsuarioInvitado.Controls.Add(this.btnBuscar);
            this.gpbUsuarioInvitado.Controls.Add(this.txtNomUsuario);
            this.gpbUsuarioInvitado.Controls.Add(this.lblNomUsuario);
            this.gpbUsuarioInvitado.Location = new System.Drawing.Point(29, 33);
            this.gpbUsuarioInvitado.Name = "gpbUsuarioInvitado";
            this.gpbUsuarioInvitado.Size = new System.Drawing.Size(426, 205);
            this.gpbUsuarioInvitado.TabIndex = 0;
            this.gpbUsuarioInvitado.TabStop = false;
            this.gpbUsuarioInvitado.Text = "Usuario Invitado";
            // 
            // frmInvitarUsuarioEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 297);
            this.Controls.Add(this.btnInvitar);
            this.Controls.Add(this.gpbUsuarioInvitado);
            this.Name = "frmInvitarUsuarioEquipo";
            this.Text = "frmInvitarUsuarioEquipo";
            this.Load += new System.EventHandler(this.frmInvitarUsuarioEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.gpbUsuarioInvitado.ResumeLayout(false);
            this.gpbUsuarioInvitado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInvitar;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox gpbUsuarioInvitado;
    }
}