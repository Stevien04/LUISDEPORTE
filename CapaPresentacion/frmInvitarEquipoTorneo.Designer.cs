namespace CapaPresentacion
{
    partial class frmInvitarEquipoTorneo
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
            this.txtTorneo = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.gpbEquipoInvitado = new System.Windows.Forms.GroupBox();
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNomEquipo = new System.Windows.Forms.TextBox();
            this.lblNomEquipo = new System.Windows.Forms.Label();
            this.gpbEquipoInvitado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInvitar
            // 
            this.btnInvitar.Location = new System.Drawing.Point(397, 342);
            this.btnInvitar.Name = "btnInvitar";
            this.btnInvitar.Size = new System.Drawing.Size(75, 23);
            this.btnInvitar.TabIndex = 8;
            this.btnInvitar.Text = "Invitar";
            this.btnInvitar.UseVisualStyleBackColor = true;
            // 
            // txtTorneo
            // 
            this.txtTorneo.Location = new System.Drawing.Point(227, 43);
            this.txtTorneo.Name = "txtTorneo";
            this.txtTorneo.Size = new System.Drawing.Size(100, 20);
            this.txtTorneo.TabIndex = 7;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(113, 46);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(41, 13);
            this.lblEquipo.TabIndex = 6;
            this.lblEquipo.Text = "Torneo";
            // 
            // gpbEquipoInvitado
            // 
            this.gpbEquipoInvitado.Controls.Add(this.dgvEquipo);
            this.gpbEquipoInvitado.Controls.Add(this.btnBuscar);
            this.gpbEquipoInvitado.Controls.Add(this.txtNomEquipo);
            this.gpbEquipoInvitado.Controls.Add(this.lblNomEquipo);
            this.gpbEquipoInvitado.Location = new System.Drawing.Point(72, 86);
            this.gpbEquipoInvitado.Name = "gpbEquipoInvitado";
            this.gpbEquipoInvitado.Size = new System.Drawing.Size(426, 249);
            this.gpbEquipoInvitado.TabIndex = 5;
            this.gpbEquipoInvitado.TabStop = false;
            this.gpbEquipoInvitado.Text = "Usuario Invitado";
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.AllowUserToAddRows = false;
            this.dgvEquipo.AllowUserToDeleteRows = false;
            this.dgvEquipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Location = new System.Drawing.Point(32, 99);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.ReadOnly = true;
            this.dgvEquipo.Size = new System.Drawing.Size(350, 76);
            this.dgvEquipo.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(180, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNomEquipo
            // 
            this.txtNomEquipo.Location = new System.Drawing.Point(155, 33);
            this.txtNomEquipo.Name = "txtNomEquipo";
            this.txtNomEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNomEquipo.TabIndex = 1;
            // 
            // lblNomEquipo
            // 
            this.lblNomEquipo.AutoSize = true;
            this.lblNomEquipo.Location = new System.Drawing.Point(41, 36);
            this.lblNomEquipo.Name = "lblNomEquipo";
            this.lblNomEquipo.Size = new System.Drawing.Size(95, 13);
            this.lblNomEquipo.TabIndex = 0;
            this.lblNomEquipo.Text = "Nombre de Equipo";
            // 
            // frmInvitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btnInvitar);
            this.Controls.Add(this.txtTorneo);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.gpbEquipoInvitado);
            this.Name = "frmInvitar";
            this.Text = "frmInvitar";
            this.Load += new System.EventHandler(this.frmInvitar_Load);
            this.gpbEquipoInvitado.ResumeLayout(false);
            this.gpbEquipoInvitado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvitar;
        private System.Windows.Forms.TextBox txtTorneo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.GroupBox gpbEquipoInvitado;
        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNomEquipo;
        private System.Windows.Forms.Label lblNomEquipo;
    }
}