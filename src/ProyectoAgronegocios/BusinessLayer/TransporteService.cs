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
    class TransporteService
    {
        private TransporteDAO daoTransporte = new TransporteDAO();

        public void registrarTransporte(Transporte transporte)
        {
            daoTransporte.registrarTransporte(transporte);
        }

        public void modificarTransporte(Transporte transporte)
        {
            daoTransporte.modificarTransporte(transporte);
        }

        public void borrarTransporte(int id)
        {
            daoTransporte.borrarTransporte(id);
        }
        public DataTable consultarTransporteSinParametros()
        {
            return daoTransporte.consultarTransporteSinParametros();
        }
        public DataTable consultarTransporteConRazonSocial(string rs)
        {
            return daoTransporte.consultarTransporteConRazonSocial(rs);
        }

        public DataTable recuperarDatosTransporte(int id)
        {
            return daoTransporte.recuperarDatosTransporte(id);
        }
    }
}
