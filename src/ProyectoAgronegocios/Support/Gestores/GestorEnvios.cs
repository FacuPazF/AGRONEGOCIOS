using ProyectoAgronegocios.BusinessLayer;
using ProyectoAgronegocios.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAgronegocios.Support.Gestores
{
    class GestorEnvios
    {
        private Cliente clienteSeleccionado;
        private ProvinciaService sProvincia = new ProvinciaService();
        private BarrioService sBarrio = new BarrioService();
        private LocalidadService sLocalidad = new LocalidadService();
        private TransporteService sTransporte = new TransporteService();
        private ClienteService sCliente = new ClienteService();
        private FacturaService sFactura = new FacturaService();
        private Factura facturaSeleccionada;
        private EmpleadoService sEmpleado = new EmpleadoService();

        // ----- Métodos get y set
        public Cliente ClienteSeleccionado { get => clienteSeleccionado; set => clienteSeleccionado = value; }
        internal ProvinciaService SProvincia { get => sProvincia; set => sProvincia = value; }
        internal BarrioService SBarrio { get => sBarrio; set => sBarrio = value; }
        internal LocalidadService SLocalidad { get => sLocalidad; set => sLocalidad = value; }
        internal TransporteService STransporte { get => sTransporte; set => sTransporte = value; }
        public Factura FacturaSeleccionada { get => facturaSeleccionada; set => facturaSeleccionada = value; }



        // ------ Métodos Críticos
        public void buscarClienteSeleccionado(string cuit_cuil)
        {
            DataTable cliente = sCliente.consultarClientesConCuil(cuit_cuil);
            ClienteSeleccionado = null;

            if (cliente.Rows.Count == 1)
            {
                ClienteSeleccionado = new Cliente();
                ClienteSeleccionado.Id_Cliente_Proveedor = (int)cliente.Rows[0]["ID"];
                ClienteSeleccionado.Nombre = cliente.Rows[0]["Nombre"].ToString();
                ClienteSeleccionado.Apellido = cliente.Rows[0]["Apellido"].ToString();
                ClienteSeleccionado.Razon_Social = cliente.Rows[0]["Razon Social"].ToString();
                ClienteSeleccionado.Cuil_cuit = cliente.Rows[0]["Cuil o Cuit"].ToString();
            }
        }

        public void registrarEnvio()
        {
            MessageBox.Show("Envío registrado");
        }
        public DataTable buscarFacturasCliente(Cliente unCliente)
        {
            return sFactura.buscarFacturasPorCliente(unCliente.Id_Cliente_Proveedor);
        }


        // ----- Métodos de soporte

        public DataTable buscarProvincias()
        {
            return SProvincia.recuperarProvincias();
        }
        public DataTable buscarEmpresasTransporte()
        {
            return STransporte.consultarTransporteSinParametros();
        }
        public DataTable buscarLocalidades()
        {
            return SLocalidad.recuperarLocalidades();
        }
        public DataTable buscarBarrios()
        {
            return SBarrio.recuperarBarrios();
        }
        public DataTable buscarLocalidades(int id_prov)
        {
            return SLocalidad.recuperarLocalidades(id_prov);
        }

        public void tomarFacturaSeleccionada(DataGridViewRow factura)
        {
            FacturaSeleccionada = new Factura();
            FacturaSeleccionada.Tipo_factura = factura.Cells["tipo_Factura"].Value.ToString();
            FacturaSeleccionada.Numero = (int)factura.Cells["numero"].Value;
            FacturaSeleccionada.Fecha_Factura = Convert.ToDateTime(factura.Cells["fecha_Factura"].Value);
            FacturaSeleccionada.Total = Convert.ToDouble(factura.Cells["total"].Value);
            FacturaSeleccionada.Cod_Empleado = (int)factura.Cells["empleado"].Value;
        }

        public DataTable recuperarDetalles()
        {
           
            return sFactura.recuperarDetalles(FacturaSeleccionada.Numero, FacturaSeleccionada.Tipo_factura);
        }

        public string recuperarEmpleadoPorID()
        {
            DataTable empleado = sEmpleado.recuperarDatosEmpleado(FacturaSeleccionada.Cod_Empleado);
            string nomApe = empleado.Rows[0]["Nombre"].ToString() + " " + empleado.Rows[0]["Apellido"].ToString();
            return nomApe;
        }

    }
}
