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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.btnInvita = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(16, 182);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(371, 138);
            this.dgvUsuario.TabIndex = 6;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtNomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsuario.Location = new System.Drawing.Point(184, 98);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(203, 27);
            this.txtNomUsuario.TabIndex = 1;
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsuario.Location = new System.Drawing.Point(12, 99);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(158, 21);
            this.lblNomUsuario.TabIndex = 0;
            this.lblNomUsuario.Text = "Nombre de Usuario";
            // 
            // txtEquipo
            // 
            this.txtEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.txtEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipo.Location = new System.Drawing.Point(184, 62);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(203, 27);
            this.txtEquipo.TabIndex = 3;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(102, 64);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(64, 21);
            this.lblEquipo.TabIndex = 2;
            this.lblEquipo.Text = "Equipo";
            // 
            // btnInvita
            // 
            this.btnInvita.BackColor = System.Drawing.Color.LightGray;
            this.btnInvita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvita.Location = new System.Drawing.Point(106, 326);
            this.btnInvita.Name = "btnInvita";
            this.btnInvita.Size = new System.Drawing.Size(202, 45);
            this.btnInvita.TabIndex = 65;
            this.btnInvita.Text = "Invitar";
            this.btnInvita.UseVisualStyleBackColor = false;
            this.btnInvita.Click += new System.EventHandler(this.btnInvita_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.LightGray;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(241, 131);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(146, 45);
            this.btnBusca.TabIndex = 66;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(75, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 36);
            this.lblTitulo.TabIndex = 76;
            this.lblTitulo.Text = "INVITAR USUARIO";
            // 
            // frmInvitarUsuarioEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(432, 413);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnInvita);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.lblNomUsuario);
            this.Name = "frmInvitarUsuarioEquipo";
            this.Text = "frmInvitarUsuarioEquipo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnInvita;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label lblTitulo;
    }
}