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
            this.gpbUsuarioInvitado = new System.Windows.Forms.GroupBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.txtUsuarioInvitado = new System.Windows.Forms.TextBox();
            this.lblUsuarioInvitado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInvitar = new System.Windows.Forms.Button();
            this.gpbUsuarioInvitado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbUsuarioInvitado
            // 
            this.gpbUsuarioInvitado.Controls.Add(this.dgvUsuario);
            this.gpbUsuarioInvitado.Controls.Add(this.txtUsuarioInvitado);
            this.gpbUsuarioInvitado.Controls.Add(this.lblUsuarioInvitado);
            this.gpbUsuarioInvitado.Controls.Add(this.btnBuscar);
            this.gpbUsuarioInvitado.Controls.Add(this.txtNomUsuario);
            this.gpbUsuarioInvitado.Controls.Add(this.lblNomUsuario);
            this.gpbUsuarioInvitado.Location = new System.Drawing.Point(28, 86);
            this.gpbUsuarioInvitado.Name = "gpbUsuarioInvitado";
            this.gpbUsuarioInvitado.Size = new System.Drawing.Size(426, 249);
            this.gpbUsuarioInvitado.TabIndex = 0;
            this.gpbUsuarioInvitado.TabStop = false;
            this.gpbUsuarioInvitado.Text = "Usuario Invitado";
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
            // txtUsuarioInvitado
            // 
            this.txtUsuarioInvitado.Location = new System.Drawing.Point(155, 193);
            this.txtUsuarioInvitado.Name = "txtUsuarioInvitado";
            this.txtUsuarioInvitado.ReadOnly = true;
            this.txtUsuarioInvitado.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioInvitado.TabIndex = 5;
            // 
            // lblUsuarioInvitado
            // 
            this.lblUsuarioInvitado.AutoSize = true;
            this.lblUsuarioInvitado.Location = new System.Drawing.Point(41, 196);
            this.lblUsuarioInvitado.Name = "lblUsuarioInvitado";
            this.lblUsuarioInvitado.Size = new System.Drawing.Size(92, 13);
            this.lblUsuarioInvitado.TabIndex = 4;
            this.lblUsuarioInvitado.Text = "IDUsuarioInvitado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(180, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(155, 33);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 1;
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
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(183, 43);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtEquipo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID EQUIPO";
            // 
            // btnInvitar
            // 
            this.btnInvitar.Location = new System.Drawing.Point(353, 342);
            this.btnInvitar.Name = "btnInvitar";
            this.btnInvitar.Size = new System.Drawing.Size(75, 23);
            this.btnInvitar.TabIndex = 4;
            this.btnInvitar.Text = "Invitar";
            this.btnInvitar.UseVisualStyleBackColor = true;
            this.btnInvitar.Click += new System.EventHandler(this.btnInvitar_Click);
            // 
            // frmInvitarUsuarioEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 413);
            this.Controls.Add(this.btnInvitar);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbUsuarioInvitado);
            this.Name = "frmInvitarUsuarioEquipo";
            this.Text = "frmInvitarUsuarioEquipo";
            this.Load += new System.EventHandler(this.frmInvitarUsuarioEquipo_Load);
            this.gpbUsuarioInvitado.ResumeLayout(false);
            this.gpbUsuarioInvitado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbUsuarioInvitado;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtUsuarioInvitado;
        private System.Windows.Forms.Label lblUsuarioInvitado;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnInvitar;
    }
}