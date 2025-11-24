namespace CapaPresentacion
{
    partial class frmPrincipal
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlEquipo = new System.Windows.Forms.Panel();
            this.btnListarEquipo = new System.Windows.Forms.Button();
            this.btnCrearEquipo = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.pnlTorneo = new System.Windows.Forms.Panel();
            this.btnListarTorneos = new System.Windows.Forms.Button();
            this.btnCrearTorneo = new System.Windows.Forms.Button();
            this.btnTorneo = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlEquipo.SuspendLayout();
            this.pnlTorneo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlSideMenu.Controls.Add(this.pnlEquipo);
            this.pnlSideMenu.Controls.Add(this.btnEquipo);
            this.pnlSideMenu.Controls.Add(this.pnlTorneo);
            this.pnlSideMenu.Controls.Add(this.btnTorneo);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(219, 561);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pnlEquipo
            // 
            this.pnlEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.pnlEquipo.Controls.Add(this.btnListarEquipo);
            this.pnlEquipo.Controls.Add(this.btnCrearEquipo);
            this.pnlEquipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEquipo.Location = new System.Drawing.Point(0, 300);
            this.pnlEquipo.Name = "pnlEquipo";
            this.pnlEquipo.Size = new System.Drawing.Size(219, 93);
            this.pnlEquipo.TabIndex = 1;
            // 
            // btnListarEquipo
            // 
            this.btnListarEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.btnListarEquipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarEquipo.FlatAppearance.BorderSize = 0;
            this.btnListarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEquipo.ForeColor = System.Drawing.Color.Black;
            this.btnListarEquipo.Location = new System.Drawing.Point(0, 40);
            this.btnListarEquipo.Name = "btnListarEquipo";
            this.btnListarEquipo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListarEquipo.Size = new System.Drawing.Size(219, 40);
            this.btnListarEquipo.TabIndex = 3;
            this.btnListarEquipo.Text = "Listar Equipo";
            this.btnListarEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarEquipo.UseVisualStyleBackColor = false;
            this.btnListarEquipo.Click += new System.EventHandler(this.btnListarEquipo_Click);
            // 
            // btnCrearEquipo
            // 
            this.btnCrearEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.btnCrearEquipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearEquipo.FlatAppearance.BorderSize = 0;
            this.btnCrearEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEquipo.ForeColor = System.Drawing.Color.Black;
            this.btnCrearEquipo.Location = new System.Drawing.Point(0, 0);
            this.btnCrearEquipo.Name = "btnCrearEquipo";
            this.btnCrearEquipo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCrearEquipo.Size = new System.Drawing.Size(219, 40);
            this.btnCrearEquipo.TabIndex = 2;
            this.btnCrearEquipo.Text = "Crear Equipo";
            this.btnCrearEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearEquipo.UseVisualStyleBackColor = false;
            this.btnCrearEquipo.Click += new System.EventHandler(this.btnCrearEquipo_Click);
            // 
            // btnEquipo
            // 
            this.btnEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(130)))));
            this.btnEquipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipo.ForeColor = System.Drawing.Color.Black;
            this.btnEquipo.Location = new System.Drawing.Point(0, 255);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEquipo.Size = new System.Drawing.Size(219, 45);
            this.btnEquipo.TabIndex = 2;
            this.btnEquipo.Text = "Equipo";
            this.btnEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipo.UseVisualStyleBackColor = false;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // pnlTorneo
            // 
            this.pnlTorneo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.pnlTorneo.Controls.Add(this.btnListarTorneos);
            this.pnlTorneo.Controls.Add(this.btnCrearTorneo);
            this.pnlTorneo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTorneo.Location = new System.Drawing.Point(0, 155);
            this.pnlTorneo.Name = "pnlTorneo";
            this.pnlTorneo.Size = new System.Drawing.Size(219, 100);
            this.pnlTorneo.TabIndex = 1;
            // 
            // btnListarTorneos
            // 
            this.btnListarTorneos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarTorneos.FlatAppearance.BorderSize = 0;
            this.btnListarTorneos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTorneos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTorneos.ForeColor = System.Drawing.Color.Black;
            this.btnListarTorneos.Location = new System.Drawing.Point(0, 40);
            this.btnListarTorneos.Name = "btnListarTorneos";
            this.btnListarTorneos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListarTorneos.Size = new System.Drawing.Size(219, 40);
            this.btnListarTorneos.TabIndex = 2;
            this.btnListarTorneos.Text = "Listar Torneos";
            this.btnListarTorneos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarTorneos.UseVisualStyleBackColor = true;
            this.btnListarTorneos.Click += new System.EventHandler(this.btnListarTorneos_Click);
            // 
            // btnCrearTorneo
            // 
            this.btnCrearTorneo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.btnCrearTorneo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearTorneo.FlatAppearance.BorderSize = 0;
            this.btnCrearTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTorneo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTorneo.ForeColor = System.Drawing.Color.Black;
            this.btnCrearTorneo.Location = new System.Drawing.Point(0, 0);
            this.btnCrearTorneo.Name = "btnCrearTorneo";
            this.btnCrearTorneo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCrearTorneo.Size = new System.Drawing.Size(219, 40);
            this.btnCrearTorneo.TabIndex = 1;
            this.btnCrearTorneo.Text = "Crear Torneo";
            this.btnCrearTorneo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearTorneo.UseVisualStyleBackColor = false;
            this.btnCrearTorneo.Click += new System.EventHandler(this.btnCrearTorneo_Click);
            // 
            // btnTorneo
            // 
            this.btnTorneo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(130)))));
            this.btnTorneo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTorneo.FlatAppearance.BorderSize = 0;
            this.btnTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTorneo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTorneo.ForeColor = System.Drawing.Color.Black;
            this.btnTorneo.Location = new System.Drawing.Point(0, 110);
            this.btnTorneo.Name = "btnTorneo";
            this.btnTorneo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTorneo.Size = new System.Drawing.Size(219, 45);
            this.btnTorneo.TabIndex = 1;
            this.btnTorneo.Text = "Torneo";
            this.btnTorneo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTorneo.UseVisualStyleBackColor = false;
            this.btnTorneo.Click += new System.EventHandler(this.btnTorneo_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(219, 110);
            this.pnlLogo.TabIndex = 1;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(76)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(219, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(715, 561);
            this.pnlContenedor.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlEquipo.ResumeLayout(false);
            this.pnlTorneo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnTorneo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTorneo;
        private System.Windows.Forms.Button btnCrearTorneo;
        private System.Windows.Forms.Button btnListarTorneos;
        private System.Windows.Forms.Panel pnlEquipo;
        private System.Windows.Forms.Button btnListarEquipo;
        private System.Windows.Forms.Button btnCrearEquipo;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}