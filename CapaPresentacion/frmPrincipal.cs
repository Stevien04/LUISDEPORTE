using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            mtdCustomDeding();
        }

        private void mtdCustomDeding()
        {
            pnlEquipo.Visible = false;
            pnlTorneo.Visible = false;
        }

        private void mtdHideSubMenu()
        {
            if (pnlEquipo.Visible == true)
            {
                pnlEquipo.Visible = false;
            }

            if (pnlTorneo.Visible == true)
            {
                pnlTorneo.Visible = false;
            }
        }

        private void mtdShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                mtdHideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            mtdShowSubMenu(pnlTorneo);
        }

        private void btnCrearTorneo_Click(object sender, EventArgs e)
        {
            mtdAbrirFormulario(new frmCrearTorneo());

            mtdHideSubMenu();
        }

        private Form FormularioActivo = null;
        private void mtdAbrirFormulario(Form FormularioVista)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            
            FormularioActivo = FormularioVista;
            FormularioVista.TopLevel = false;
            FormularioVista.FormBorderStyle = FormBorderStyle.None;
            FormularioVista.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Add(FormularioVista);
            pnlContenedor.Tag = FormularioVista;
            FormularioVista.BringToFront();
            FormularioVista.Show();
        }

        private void btnListarTorneos_Click(object sender, EventArgs e)
        {
            mtdAbrirFormulario(new frmListarTorneos());

            mtdHideSubMenu();
        }

        private void btnCrearEquipo_Click(object sender, EventArgs e)
        {
            mtdAbrirFormulario(new frmCrearEquipo());

            mtdHideSubMenu();
        }

        private void btnListarEquipo_Click(object sender, EventArgs e)
        {
            mtdAbrirFormulario(new frmListarEquipos());

            mtdHideSubMenu();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            mtdShowSubMenu(pnlEquipo);
        }

        private void btnNotificacionesEquipo_Click(object sender, EventArgs e)
        {
            mtdAbrirFormulario(new frmNoticacionesEquipo());

            mtdHideSubMenu();
        }

        private void btnNotificacionesTorneo_Click(object sender, EventArgs e)
        {
            mtdAbrirFormulario(new frmNotificacionesTorneo());

            mtdHideSubMenu();
        }
    }
}
