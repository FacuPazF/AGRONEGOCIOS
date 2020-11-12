using ProyectoAgronegocios.Support.Gestores;
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
    public partial class frmDetFacturaConsulta : Form
    {
        private GestorEnvios gesEnvio = new GestorEnvios();
        internal GestorEnvios GesEnvio { get => gesEnvio; set => gesEnvio = value; }

        public frmDetFacturaConsulta()
        {
            InitializeComponent();
        }

        private void frmDetFacturaConsulta_Load(object sender, EventArgs e)
        {
            lblNroFactura.Text += " " + gesEnvio.FacturaSeleccionada.Numero;
            lblTipoFactura.Text += " " + gesEnvio.FacturaSeleccionada.Tipo_factura;
            lblFechaFactura.Text += " " + gesEnvio.FacturaSeleccionada.Fecha_Factura.ToString("dd-MM-yyyy");
            lblEmpleado.Text += " " + gesEnvio.recuperarEmpleadoPorID();
            lblTotal.Text += " " + gesEnvio.FacturaSeleccionada.Total;

            DataTable detalles = gesEnvio.recuperarDetalles();
            if (detalles.Rows.Count != 0)
            {
                for (int i = 0; i < detalles.Rows.Count; i++)
                {
                    dtgDetalles.Rows.Add(
                        detalles.Rows[i]["nombreSemilla"],
                        detalles.Rows[i]["cantidad"],
                        detalles.Rows[i]["precio"],
                        detalles.Rows[i]["subtotal"]);
                }


            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
