using CapaNegocio;
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
    public partial class frmCrearTorneo : Form
    {
        private clsGestionTorneos_CN ObjGestionTorneos = new clsGestionTorneos_CN();

        private string NombreUsuario = clsSesionUsuario_CN.NombreUsuario.ToString();
        private int IDCreador = clsSesionUsuario_CN.idUsuario;

        public frmCrearTorneo()
        {
            InitializeComponent();
        }

        private void btnCrearTorneo_Click(object sender, EventArgs e)
        {
            string nombreTorneo = txtNombreTorneo.Text;
            string descripcion = txtDescripcion.Text;

            if (string.IsNullOrWhiteSpace(nombreTorneo))
            {
                MessageBox.Show("Ingrese un nombre para el torneo.", "Nombre requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idTorneo = ObjGestionTorneos.mtdCrearTorneoCN(IDCreador, nombreTorneo, descripcion);

            if (idTorneo > 0)
            {
                MessageBox.Show(
                    "El torneo se creó correctamente. Puedes invitar equipos más tarde desde la lista de torneos.",
                    "Torneo creado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNombreTorneo.Clear();
                txtDescripcion.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo crear el torneo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCrearTorneo_Load(object sender, EventArgs e)
        {
            txtCreador.Text = NombreUsuario;
        }
    }
}
