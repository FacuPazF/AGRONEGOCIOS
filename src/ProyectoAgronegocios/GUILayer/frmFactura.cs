using ProyectoAgronegocios.BusinessLayer;
using ProyectoAgronegocios.Entities;
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
        private int id_Cliente = -1;
        private SemillaService sSemilla = new SemillaService();
        private FacturaService sFactura = new FacturaService();
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
            if (Int32.TryParse(txtCantidad.Text, out num) && txtNombreSemilla.Text != "")
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
            if (txtCantidad.Text != "")
            {
                dtgDetalles.Rows.Add(
                txtIdSemilla.Text,
                txtNombreSemilla.Text,
                lblPrecioSugerido.Text,
                txtCantidad.Text,
                txtPrecioDetalle.Text
                );
                lblTotalNum.Text = (Convert.ToDouble(lblTotalNum.Text) + Convert.ToDouble(txtPrecioDetalle.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese Cantidad", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
            }
                
            
            
            


        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dtgDetalles.CurrentRow.Selected && 
                MessageBox.Show("¿Desea eliminar el detalle seleccionado?","", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lblTotalNum.Text = (Convert.ToDouble(lblTotalNum.Text) - 
                            Convert.ToDouble(dtgDetalles.CurrentRow.Cells["Subtotal"].Value)).ToString();
                dtgDetalles.Rows.Remove(dtgDetalles.CurrentRow);
                MessageBox.Show("Detalle eliminado");
            }
            else
            {
                MessageBox.Show("Seleccione un Detalle");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Factura oFact = new Factura(cboTipoFactura.Text, -1, dtpFechaFactura.Value, 
                            Convert.ToDouble(lblTotalNum.Text), Sesion.GetInstance().User.Cod_Empleado, id_Cliente);
            List<DetalleFactura> lista = new List<DetalleFactura>();
            for (int i = 0; i < dtgDetalles.Rows.Count; i++)
            {
                DetalleFactura oDetalleFact = new DetalleFactura();
                oDetalleFact.Tipo_Factura = cboTipoFactura.Text;
                oDetalleFact.Id_Semilla = Convert.ToInt32(dtgDetalles.Rows[i].Cells["id_Semilla"].Value);
                oDetalleFact.Precio_Venta = Convert.ToDouble(dtgDetalles.Rows[i].Cells["precioVenta"].Value);
                oDetalleFact.Cantidad = Convert.ToInt32(dtgDetalles.Rows[i].Cells["cantidad"].Value);
                oDetalleFact.Subtotal = Convert.ToDouble(dtgDetalles.Rows[i].Cells["subTotal"].Value);
                lista.Add(oDetalleFact);
                
            }
            if (lista.Count != 0 && id_Cliente != -1 && cboTipoFactura.Text != "" )
            {
                sFactura.InsertarFactura(oFact, lista);
                MessageBox.Show("Factura Generada con Éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan agregar detalles o cliente o el tipo de factura");
            }
                

        }
    }
}
