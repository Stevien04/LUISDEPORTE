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
    public partial class frmListarEquipos : Form
    {
        private clsGestionEquipos_CN ObjGestionEquipos = new clsGestionEquipos_CN();

        int IDUsuarioActual = clsSesionUsuario_CN.idUsuario;


        public frmListarEquipos()
        {
            InitializeComponent();
        }

        private void mtdCargarEquipos()
        {
            flpListaEquipos.Controls.Clear();

            DataTable tabla = ObjGestionEquipos.mtdListarEquiposPorUsuarioCD(IDUsuarioActual);

            foreach (DataRow fila in tabla.Rows)
            {
                usEquipoItem item = new usEquipoItem();

                item.NombreEquipo = fila["NombreEquipo"].ToString();
                item.Descripcion = fila["Descripcion"].ToString();

                // FECHA DE CREACIÓN
                item.FechaCreacion = Convert.ToDateTime(fila["FechaRegistro"])
                                       .ToString("dd/MM/yyyy HH:mm");

                // FECHA DE MODIFICACIÓN (puede ser null)
                if (fila["FechaModificacion"] != DBNull.Value)
                    item.FechaModificacion = Convert.ToDateTime(fila["FechaModificacion"])
                                              .ToString("dd/MM/yyyy HH:mm");
                else
                    item.FechaModificacion = "—";

                flpListaEquipos.Controls.Add(item);
            }
        }

        private void frmListarEquipos_Load(object sender, EventArgs e)
        {
            mtdCargarEquipos();
        }
    }
}
