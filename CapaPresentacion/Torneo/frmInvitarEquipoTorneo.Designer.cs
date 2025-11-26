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
            this.txtTorneo = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.txtNomEquipo = new System.Windows.Forms.TextBox();
            this.lblNomEquipo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnInvita = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTorneo
            // 
            this.txtTorneo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtTorneo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTorneo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTorneo.Location = new System.Drawing.Point(187, 66);
            this.txtTorneo.Name = "txtTorneo";
            this.txtTorneo.ReadOnly = true;
            this.txtTorneo.Size = new System.Drawing.Size(221, 27);
            this.txtTorneo.TabIndex = 7;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(67, 69);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(63, 21);
            this.lblEquipo.TabIndex = 6;
            this.lblEquipo.Text = "Torneo";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(187, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 27);
            this.txtUsuario.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de Usuario";
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.AllowUserToAddRows = false;
            this.dgvEquipo.AllowUserToDeleteRows = false;
            this.dgvEquipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Location = new System.Drawing.Point(18, 212);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.ReadOnly = true;
            this.dgvEquipo.Size = new System.Drawing.Size(390, 124);
            this.dgvEquipo.TabIndex = 6;
            this.dgvEquipo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellClick);
            // 
            // txtNomEquipo
            // 
            this.txtNomEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtNomEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomEquipo.Location = new System.Drawing.Point(187, 130);
            this.txtNomEquipo.Name = "txtNomEquipo";
            this.txtNomEquipo.Size = new System.Drawing.Size(221, 27);
            this.txtNomEquipo.TabIndex = 1;
            // 
            // lblNomEquipo
            // 
            this.lblNomEquipo.AutoSize = true;
            this.lblNomEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEquipo.Location = new System.Drawing.Point(14, 133);
            this.lblNomEquipo.Name = "lblNomEquipo";
            this.lblNomEquipo.Size = new System.Drawing.Size(156, 21);
            this.lblNomEquipo.TabIndex = 0;
            this.lblNomEquipo.Text = "Nombre de Equipo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(121, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 36);
            this.lblTitulo.TabIndex = 77;
            this.lblTitulo.Text = "INVITAR A EQUIPO";
            // 
            // btnInvita
            // 
            this.btnInvita.BackColor = System.Drawing.Color.LightGray;
            this.btnInvita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvita.Location = new System.Drawing.Point(127, 351);
            this.btnInvita.Name = "btnInvita";
            this.btnInvita.Size = new System.Drawing.Size(202, 45);
            this.btnInvita.TabIndex = 78;
            this.btnInvita.Text = "Invitar";
            this.btnInvita.UseVisualStyleBackColor = false;
            this.btnInvita.Click += new System.EventHandler(this.btnInvita_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.LightGray;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(181, 163);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(146, 45);
            this.btnBusca.TabIndex = 79;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // frmInvitarEquipoTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.btnInvita);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTorneo);
            this.Controls.Add(this.dgvEquipo);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.txtNomEquipo);
            this.Controls.Add(this.lblNomEquipo);
            this.Name = "frmInvitarEquipoTorneo";
            this.Text = "frmInvitar";
            this.Load += new System.EventHandler(this.frmInvitar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTorneo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.TextBox txtNomEquipo;
        private System.Windows.Forms.Label lblNomEquipo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnInvita;
        private System.Windows.Forms.Button btnBusca;
    }
}