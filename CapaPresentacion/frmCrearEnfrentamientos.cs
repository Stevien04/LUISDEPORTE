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
    public partial class frmCrearEnfrentamientos : Form
    {
        private readonly clsGestionEquipos_CN _gestionEquipos = new clsGestionEquipos_CN();
        private readonly int _idUsuarioActual = clsSesionUsuario_CN.idUsuario;

        private DataTable _equiposDisponibles;
        private DataTable _enfrentamientosGenerados;

        public frmCrearEnfrentamientos()
        {
            InitializeComponent();
            this.Load += frmCrearEnfrentamientos_Load;
        }

        private void frmCrearEnfrentamientos_Load(object sender, EventArgs e)
        {
            PrepararTablaEnfrentamientos();
            CargarEquipos();
        }

        private void PrepararTablaEnfrentamientos()
        {
            _enfrentamientosGenerados = new DataTable();
            _enfrentamientosGenerados.Columns.Add("Equipo 1");
            _enfrentamientosGenerados.Columns.Add("Equipo 2");

            dgvEnfrentamientos.DataSource = _enfrentamientosGenerados;
            dgvEnfrentamientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarEquipos()
        {
            _equiposDisponibles = _gestionEquipos.mtdListarEquiposPorUsuarioCD(_idUsuarioActual);
            dgvEquipos.DataSource = _equiposDisponibles;

            if (dgvEquipos.Columns.Contains("IDEquipo"))
            {
                dgvEquipos.Columns["IDEquipo"].Visible = false;
            }

            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGenerarEnfrentamiento_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count != 2)
            {
                MessageBox.Show("Seleccione exactamente dos equipos para generar un enfrentamiento.",
                    "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow filaEquipo1 = dgvEquipos.SelectedRows[0];
            DataGridViewRow filaEquipo2 = dgvEquipos.SelectedRows[1];

            string nombreEquipo1 = filaEquipo1.Cells["NombreEquipo"].Value.ToString();
            string nombreEquipo2 = filaEquipo2.Cells["NombreEquipo"].Value.ToString();

            _enfrentamientosGenerados.Rows.Add(nombreEquipo1, nombreEquipo2);

            RemoverEquipoDeLaLista(Convert.ToInt32(filaEquipo1.Cells["IDEquipo"].Value));
            RemoverEquipoDeLaLista(Convert.ToInt32(filaEquipo2.Cells["IDEquipo"].Value));

            if (_equiposDisponibles.Rows.Count == 0)
            {
                MessageBox.Show("No quedan equipos disponibles en la lista.", "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void RemoverEquipoDeLaLista(int idEquipo)
        {
            DataRow fila = _equiposDisponibles.AsEnumerable()
                .FirstOrDefault(r => r.Field<int>("IDEquipo") == idEquipo);

            if (fila != null)
            {
                _equiposDisponibles.Rows.Remove(fila);
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            _enfrentamientosGenerados.Rows.Clear();
            CargarEquipos();
        }
    }
}
