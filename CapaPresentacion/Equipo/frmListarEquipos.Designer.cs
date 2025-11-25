namespace CapaPresentacion
{
    partial class frmListarEquipos
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
            this.flpListaEquipos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpListaEquipos
            // 
            this.flpListaEquipos.AutoScroll = true;
            this.flpListaEquipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListaEquipos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListaEquipos.Location = new System.Drawing.Point(0, 0);
            this.flpListaEquipos.Name = "flpListaEquipos";
            this.flpListaEquipos.Size = new System.Drawing.Size(699, 522);
            this.flpListaEquipos.TabIndex = 0;
            this.flpListaEquipos.WrapContents = false;
            // 
            // frmListarEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(699, 522);
            this.Controls.Add(this.flpListaEquipos);
            this.Name = "frmListarEquipos";
            this.Text = "frmListarEquipos";
            this.Load += new System.EventHandler(this.frmListarEquipos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpListaEquipos;
    }
}