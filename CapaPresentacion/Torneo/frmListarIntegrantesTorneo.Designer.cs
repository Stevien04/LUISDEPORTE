namespace CapaPresentacion
{
    partial class frmListarIntegrantesTorneo
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
            this.dgvIntegrantesTorneo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantesTorneo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIntegrantesTorneo
            // 
            this.dgvIntegrantesTorneo.AllowUserToAddRows = false;
            this.dgvIntegrantesTorneo.AllowUserToDeleteRows = false;
            this.dgvIntegrantesTorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrantesTorneo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIntegrantesTorneo.Location = new System.Drawing.Point(0, 0);
            this.dgvIntegrantesTorneo.Name = "dgvIntegrantesTorneo";
            this.dgvIntegrantesTorneo.ReadOnly = true;
            this.dgvIntegrantesTorneo.Size = new System.Drawing.Size(800, 450);
            this.dgvIntegrantesTorneo.TabIndex = 0;
            // 
            // frmListarIntegrantesTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIntegrantesTorneo);
            this.Name = "frmListarIntegrantesTorneo";
            this.Text = "gdvIntegrantesTorneo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantesTorneo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIntegrantesTorneo;
    }
}