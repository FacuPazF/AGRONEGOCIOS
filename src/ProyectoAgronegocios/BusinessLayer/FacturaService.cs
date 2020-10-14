using ProyectoAgronegocios.DataAccessLayer;
using ProyectoAgronegocios.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.BusinessLayer
{
    class FacturaService
    {
        FacturaDAO facturaDAO = new FacturaDAO();
        public void InsertarFactura(Factura oFact, List<DetalleFactura> lista_DF, List<FormaPagoXfactura> lista_FP)
        {
            facturaDAO.InsertarFactura(oFact, lista_DF, lista_FP);
        }

        public DataTable buscarFacturasPorCliente(int id_Cliente)
        {
            return facturaDAO.buscarFacturasPorCliente(id_Cliente);
        }

        public DataTable recuperarDetalles(int num, string tipo_factura)
        {
            return facturaDAO.recuperarDetalles(num, tipo_factura);
        }

        public DataTable buscarFacturasConParametros(DateTime fd, DateTime fh, string tf, int idc)
        {
            return facturaDAO.buscarFacturasConParametros(fd, fh, tf, idc);
        }

        public DataTable buscarDetFacturasReporte(DateTime fd, DateTime fh, int idc)
        {
            return facturaDAO.buscarDetFacturasReporte(fd, fh, idc);
        }
    }

}
