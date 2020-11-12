using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.DataAccessLayer;
using ProyectoAgronegocios.Entities;

namespace ProyectoAgronegocios.BusinessLayer
{
    class ClienteService
    {
        private ClienteDAO daoCliente = new ClienteDAO();

        // ----------  ABM
        public void registrarCliente(Cliente cliente)
        {
           daoCliente.registrarCliente(cliente);
        }

        public void modificarCliente(Cliente cliente)
        {
            daoCliente.modificarCliente(cliente);
        }

        public void borrarCliente(int id)
        {
            daoCliente.borrarCliente(id);
        }

        // ---------------- Consultas
        public DataTable consultarClientesSinParametros()
        {
            return daoCliente.consultarClientesSinParametros();
        }

        
        public DataTable consultarClientesConCuil(string cuil)
        {
            return daoCliente.consultarClientesConCuil(cuil);
        }

        public DataTable recuperarDatosCliente(int id)
        {
            return daoCliente.recuperarDatosCliente(id);
        }

        public DataTable recuperarCantidadVentas(DateTime fd, DateTime fh)
        {
            return daoCliente.recuperarCantidadVentas(fd, fh);
        }

        public DataTable recuperarCantidadVentasPrecio(DateTime fd, DateTime fh)
        {
            return daoCliente.recuperarCantidadVentasPrecio(fd, fh);
        }

        public double promedioVentasP(DateTime fd, DateTime fh) => daoCliente.promedioVentasP(fd, fh);
        

        public double promedioVentasC(DateTime fd, DateTime fh) => daoCliente.promedioVentasC(fd, fh);
        
    }
}
