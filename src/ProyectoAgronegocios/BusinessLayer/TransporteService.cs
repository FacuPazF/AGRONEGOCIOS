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
            daoTransporte.RegistrarTransporte(transporte);
        }

        public void modificarTransporte(Transporte transporte)
        {
            daoTransporte.ModificarTransporte(transporte);
        }

        public void borrarTransporte(int id)
        {
            daoTransporte.BorrarTransporte(id);
        }
        public DataTable consultarTransporteSinParametros()
        {
            return daoTransporte.ConsultarTransporteSinParametros();
        }
        public DataTable consultarTransporteConRazonSocial(string rs)
        {
            return daoTransporte.ConsultarTransporteConRazonSocial(rs);
        }

        public DataTable recuperarDatosTransporte(int id)
        {
            return daoTransporte.RecuperarDatosTransporte(id);
        }
    }
}
