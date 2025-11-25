namespace CapaPresentacion
{
    partial class frmNotificacionesTorneo
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
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvNotificacionesTorneo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificacionesTorneo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.Color.LightGray;
            this.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.Location = new System.Drawing.Point(413, 191);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(122, 30);
            this.btnRechazar.TabIndex = 71;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = false;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightGray;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(541, 191);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 30);
            this.btnAceptar.TabIndex = 70;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvNotificacionesTorneo
            // 
            this.dgvNotificacionesTorneo.AllowUserToAddRows = false;
            this.dgvNotificacionesTorneo.AllowUserToDeleteRows = false;
            this.dgvNotificacionesTorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificacionesTorneo.Location = new System.Drawing.Point(52, 35);
            this.dgvNotificacionesTorneo.MultiSelect = false;
            this.dgvNotificacionesTorneo.Name = "dgvNotificacionesTorneo";
            this.dgvNotificacionesTorneo.ReadOnly = true;
            this.dgvNotificacionesTorneo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotificacionesTorneo.Size = new System.Drawing.Size(611, 150);
            this.dgvNotificacionesTorneo.TabIndex = 69;
            this.dgvNotificacionesTorneo.SelectionChanged += new System.EventHandler(this.dgvNotificacionesTorneo_SelectionChanged_1);
            // 
            // frmNotificacionesTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvNotificacionesTorneo);
            this.Name = "frmNotificacionesTorneo";
            this.Text = "frmNotificacionesTorneo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificacionesTorneo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvNotificacionesTorneo;
    }
}