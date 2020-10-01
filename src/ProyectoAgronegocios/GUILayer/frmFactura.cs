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
        private SemillaService sSemilla = new SemillaService();
        private FacturaService sFactura = new FacturaService();
        private FormaPagoService sFP = new FormaPagoService();
        private int id_Cliente = -1;
        
        public frmFactura()
        {
            InitializeComponent();
        }
        
        // ----------- Formulario ------------------------------------------------------

        private void frmFactura_Load(object sender, EventArgs e)
        {
            lblUsuarioLoguedo.Text = "Empleado: " + Sesion.GetInstance().User.Nombre + " " +
                                    Sesion.GetInstance().User.Apellido + " (" +
                                    Sesion.GetInstance().User.Cod_Empleado + ")";
            cargarCombo(cboFormaPago1, sFP.recuperarFormasPago());
            cargarCombo(cboFormaPago2, sFP.recuperarFormasPago());
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
        private void cboFormaPago1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormaPago1.Text == "Efectivo")
            {
                nudDias1.Enabled = false;
                nudDias1.Value = 0;
            }
            else
            {
                nudDias1.Enabled = true;
            }
        }
        private void cboFormaPago2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormaPago2.Text == "Efectivo")
            {
                nudDias2.Enabled = false;
                nudDias2.Value = 0;
            }
            else
            {
                nudDias2.Enabled = true;
            }
        }
        
        // ------------- Botones -------------------------------------------------------

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

            if (txtCantidad.Text != "" )
            {
                dtgDetalles.Rows.Add(
                txtIdSemilla.Text,
                txtNombreSemilla.Text,
                lblPrecioSugerido.Text,
                txtCantidad.Text,
                txtPrecioDetalle.Text
                );
                lblTotalNum.Text = (Convert.ToDouble(lblTotalNum.Text) + Convert.ToDouble(txtPrecioDetalle.Text)).ToString();
                grbFormasPago.Enabled = true;
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
                if (Convert.ToDouble(lblTotalNum.Text) == 0)
                {
                    grbFormasPago.Enabled = false;
                }
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
            List<DetalleFactura> lista_DF = new List<DetalleFactura>();
            List<FormaPagoXfactura> lista_FP = new List<FormaPagoXfactura>();
           
            for (int i = 0; i < dtgDetalles.Rows.Count; i++)
            {
                DetalleFactura oDetalleFact = new DetalleFactura();
                oDetalleFact.Tipo_Factura = cboTipoFactura.Text;
                oDetalleFact.Id_Semilla = Convert.ToInt32(dtgDetalles.Rows[i].Cells["id_Semilla"].Value);
                oDetalleFact.Precio_Venta = Convert.ToDouble(dtgDetalles.Rows[i].Cells["precioVenta"].Value);
                oDetalleFact.Cantidad = Convert.ToInt32(dtgDetalles.Rows[i].Cells["cantidad"].Value);
                oDetalleFact.Subtotal = Convert.ToDouble(dtgDetalles.Rows[i].Cells["subTotal"].Value);
                lista_DF.Add(oDetalleFact);
                
            }

            for (int i = 0; i < dtgFormasPago.Rows.Count; i++)
            {
                FormaPagoXfactura oFormaPago = new FormaPagoXfactura();
                oFormaPago.Tipo_Factura = cboTipoFactura.Text;
                oFormaPago.Id_Forma_Pago = Convert.ToInt32(dtgFormasPago.Rows[i].Cells["id_FormaPago"].Value);
                oFormaPago.Monto = Convert.ToDouble(dtgFormasPago.Rows[i].Cells["monto"].Value);
                oFormaPago.Dias_de_Plazo = Convert.ToInt32(dtgFormasPago.Rows[i].Cells["dias_plazo"].Value);
                lista_FP.Add(oFormaPago);

            }

            double tot = 0;
            for (int i = 0; i < dtgFormasPago.Rows.Count; i++)
            {
                tot += Convert.ToDouble(dtgFormasPago.Rows[i].Cells["monto"].Value);
            }
         
            if (lista_DF.Count != 0 
                && id_Cliente != -1 
                && cboTipoFactura.Text != "" 
                && dtgFormasPago.Rows.Count != 0 
                && tot <= Convert.ToDouble(lblTotalNum.Text))
            {
                sFactura.InsertarFactura(oFact, lista_DF, lista_FP);
                MessageBox.Show("Factura Generada con Éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan agregar detalles, datos del cliente, tipo de factura o formas de pago");
            }
        }
        private void btnAgregarFP1_Click(object sender, EventArgs e)
        {
            if (txtMontoFP1.Text != "" 
                && txtMontoFP1.Text != "0" 
                && nudDias1.Value >= 0 
                && (Convert.ToDouble(txtMontoFP1.Text)) <= (Convert.ToDouble(lblTotalNum.Text))
                && cboFormaPago1.Text != "")
            {
                dtgFormasPago.Rows.Add(cboFormaPago1.SelectedValue,
                    cboFormaPago1.Text,
                    txtMontoFP1.Text,
                    nudDias1.Value
                    );
                if ((Convert.ToDouble(lblTotalNum.Text) - Convert.ToDouble(txtMontoFP1.Text)) == 0)
                {
                    btnFacturar.Focus();
                    return;
                }
                btnAgregarFP1.Enabled = false;
                lblFormaPago2.Enabled = true;
                btnAgregarFP2.Enabled = true;
                if (cboFormaPago1.Text == "Efectivo")
                {
                    cboFormaPago2.SelectedValue = 2;
                }
                else
                {
                    cboFormaPago2.SelectedValue = 1;
                }
                txtMontoFP2.Text = (Convert.ToDouble(lblTotalNum.Text) - Convert.ToDouble(txtMontoFP1.Text)).ToString();
            }
        }
        private void btnAgregarFP2_Click(object sender, EventArgs e)
        {
            if (nudDias2.Value >= 0)
            {
                dtgFormasPago.Rows.Add(cboFormaPago2.SelectedValue,
                    cboFormaPago2.Text,
                    txtMontoFP2.Text,
                    nudDias2.Value
                    );
                btnAgregarFP2.Enabled = false;
                btnFacturar.Focus();
            }
        }
        private void btnQuitarFP_Click(object sender, EventArgs e)
        {
            dtgFormasPago.Rows.Clear();
            cboFormaPago1.SelectedIndex = -1;
            cboFormaPago2.SelectedIndex = -1;
            txtMontoFP1.Clear();
            txtMontoFP2.Clear();
            nudDias1.Value = 0;
            nudDias2.Value = 0;
            btnAgregarFP1.Enabled = true;
            btnAgregarFP2.Enabled = false;
            lblFormaPago2.Enabled = false;


        }

        // -------------- Métodos de soporte -------------------------------------------

        private void cargarCombo(ComboBox combo, DataTable tabla)
        {
            
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedValue = -1;

        }

        //------------------------------------------------------------------------------

    }
}
