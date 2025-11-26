namespace CapaPresentacion
{
    partial class frmListarTorneos
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
            this.flpListaTorneo = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpListaTorneo
            // 
            this.flpListaTorneo.AutoScroll = true;
            this.flpListaTorneo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListaTorneo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListaTorneo.Location = new System.Drawing.Point(0, 0);
            this.flpListaTorneo.Name = "flpListaTorneo";
            this.flpListaTorneo.Size = new System.Drawing.Size(800, 450);
            this.flpListaTorneo.TabIndex = 1;
            this.flpListaTorneo.WrapContents = false;
            // 
            // frmListarTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpListaTorneo);
            this.Name = "frmListarTorneos";
            this.Text = "frmListarTorneos";
            this.Load += new System.EventHandler(this.frmListarTorneos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpListaTorneo;
    }
}