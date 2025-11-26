namespace CapaPresentacion
{
    partial class frmCrearEnfrentamientos
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
            this.lblEquiposDisponibles = new System.Windows.Forms.Label();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.btnGenerarEnfrentamiento = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.lblEnfrentamientos = new System.Windows.Forms.Label();
            this.dgvEnfrentamientos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnfrentamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEquiposDisponibles
            // 
            this.lblEquiposDisponibles.AutoSize = true;
            this.lblEquiposDisponibles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquiposDisponibles.Location = new System.Drawing.Point(12, 9);
            this.lblEquiposDisponibles.Name = "lblEquiposDisponibles";
            this.lblEquiposDisponibles.Size = new System.Drawing.Size(160, 19);
            this.lblEquiposDisponibles.TabIndex = 0;
            this.lblEquiposDisponibles.Text = "Equipos disponibles";
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(16, 31);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(368, 206);
            this.dgvEquipos.TabIndex = 1;
            // 
            // btnGenerarEnfrentamiento
            // 
            this.btnGenerarEnfrentamiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarEnfrentamiento.Location = new System.Drawing.Point(16, 243);
            this.btnGenerarEnfrentamiento.Name = "btnGenerarEnfrentamiento";
            this.btnGenerarEnfrentamiento.Size = new System.Drawing.Size(181, 34);
            this.btnGenerarEnfrentamiento.TabIndex = 2;
            this.btnGenerarEnfrentamiento.Text = "Generar enfrentamiento";
            this.btnGenerarEnfrentamiento.UseVisualStyleBackColor = true;
            this.btnGenerarEnfrentamiento.Click += new System.EventHandler(this.btnGenerarEnfrentamiento_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Location = new System.Drawing.Point(203, 243);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(181, 34);
            this.btnRestablecer.TabIndex = 3;
            this.btnRestablecer.Text = "Restablecer lista";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // lblEnfrentamientos
            // 
            this.lblEnfrentamientos.AutoSize = true;
            this.lblEnfrentamientos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfrentamientos.Location = new System.Drawing.Point(12, 290);
            this.lblEnfrentamientos.Name = "lblEnfrentamientos";
            this.lblEnfrentamientos.Size = new System.Drawing.Size(131, 19);
            this.lblEnfrentamientos.TabIndex = 4;
            this.lblEnfrentamientos.Text = "Enfrentamientos";
            // 
            // dgvEnfrentamientos
            // 
            this.dgvEnfrentamientos.AllowUserToAddRows = false;
            this.dgvEnfrentamientos.AllowUserToDeleteRows = false;
            this.dgvEnfrentamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnfrentamientos.Location = new System.Drawing.Point(16, 312);
            this.dgvEnfrentamientos.MultiSelect = false;
            this.dgvEnfrentamientos.Name = "dgvEnfrentamientos";
            this.dgvEnfrentamientos.ReadOnly = true;
            this.dgvEnfrentamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnfrentamientos.Size = new System.Drawing.Size(772, 150);
            this.dgvEnfrentamientos.TabIndex = 5;
            // 
            // frmCrearEnfrentamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dgvEnfrentamientos);
            this.Controls.Add(this.lblEnfrentamientos);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnGenerarEnfrentamiento);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.lblEquiposDisponibles);
            this.Name = "frmCrearEnfrentamientos";
            this.Text = "frmCrearEnfrentamientos";
            this.Load += new System.EventHandler(this.frmCrearEnfrentamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnfrentamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEquiposDisponibles;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Button btnGenerarEnfrentamiento;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Label lblEnfrentamientos;
        private System.Windows.Forms.DataGridView dgvEnfrentamientos;
    }
}