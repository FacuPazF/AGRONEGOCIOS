using ProyectoAgronegocios.BusinessLayer;
using ProyectoAgronegocios.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAgronegocios.GUILayer
{
    public partial class frmFactura : Form
    {
        private ClienteService sCliente = new ClienteService();
        private int id_Cliente;
        private SemillaService sSemilla = new SemillaService();
        public frmFactura()
        {
            InitializeComponent();
        }
        // ----------- Formulario
        private void frmFactura_Load(object sender, EventArgs e)
        {
            lblUsuarioLoguedo.Text = "Empleado: " + Sesion.GetInstance().User.Nombre + " " +
                                    Sesion.GetInstance().User.Apellido + " (" +
                                    Sesion.GetInstance().User.Cod_Empleado + ")";
        }

        private void txtIdSemilla_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if (txtIdSemilla.Text != "")
            {
                tabla = sSemilla.recuperarSemillasPorID(Convert.ToInt32(txtIdSemilla.Text));
                if (tabla.Rows.Count != 0)
                {
                    txtNombreSemilla.Text = tabla.Rows[0]["Nombre"].ToString();
                    lblCalidadSemilla.Text = "Calidad: " + tabla.Rows[0]["Nombre Calidad"].ToString();
                    lblTipoSemilla.Text = "Tipo Semilla: " + tabla.Rows[0]["Nombre Tipo Semilla"].ToString();
                    lblPrecioSugerido.Text = tabla.Rows[0]["Precio Sugerido"].ToString();
                }
                else
                {
                    txtNombreSemilla.Clear();
                    lblCalidadSemilla.Text = "Calidad: ";
                    lblTipoSemilla.Text = "Tipo Semilla: ";
                    lblPrecioSugerido.Text = " - ";
                }
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (Int32.TryParse(txtCantidad.Text, out num))
            {
                txtPrecioDetalle.Text = (Convert.ToDouble(num) * Convert.ToDouble(lblPrecioSugerido.Text)).ToString();
            }

        }
        // ------------- Botones
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtFilterCuil.Text == "" || txtFilterCuil.Text == "Ingrese Cuil o Cuit....")
            {
                txtFilterCuil.Text = "Ingrese Cuil o Cuit....";
                txtFilterCuil.Focus();
                return;
            }

            DataTable tabla = sCliente.consultarClientesConCuil(txtFilterCuil.Text);
            if (tabla.Rows.Count != 0)
            {
                id_Cliente = (int)tabla.Rows[0]["ID"];
                lblRealCuil.Text = tabla.Rows[0]["Cuil o Cuit"].ToString();
                lblRealNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            }
            else
            {
                if (MessageBox.Show("El cliente ingresado no existe. ¿Desea registrar un nuevo Cliente?",
                    "Cliente no encontrado",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    frmCliente form = new frmCliente();
                    form.ShowDialog();
                    btnBuscar_Click(sender, e);
                }
                else
                {
                    txtFilterCuil.Focus();
                }
            }
         
            
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar fila Detalle a Grilla
            //dtgDetalles.Rows.Add();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
