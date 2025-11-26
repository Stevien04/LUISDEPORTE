namespace CapaPresentacion
{
    partial class frmListarIntegrantesEquipo
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
            this.dgvIntegrantesEquipo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantesEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIntegrantesEquipo
            // 
            this.dgvIntegrantesEquipo.AllowUserToAddRows = false;
            this.dgvIntegrantesEquipo.AllowUserToDeleteRows = false;
            this.dgvIntegrantesEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrantesEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIntegrantesEquipo.Location = new System.Drawing.Point(0, 0);
            this.dgvIntegrantesEquipo.Name = "dgvIntegrantesEquipo";
            this.dgvIntegrantesEquipo.ReadOnly = true;
            this.dgvIntegrantesEquipo.Size = new System.Drawing.Size(625, 271);
            this.dgvIntegrantesEquipo.TabIndex = 0;
            // 
            // frmListarIntegrantesEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(625, 271);
            this.Controls.Add(this.dgvIntegrantesEquipo);
            this.Name = "frmListarIntegrantesEquipo";
            this.Text = "frmListarIntegrantesEquipo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantesEquipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIntegrantesEquipo;
    }
}