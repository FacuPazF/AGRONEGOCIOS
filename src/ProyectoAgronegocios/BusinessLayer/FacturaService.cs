using ProyectoAgronegocios.DataAccessLayer;
using ProyectoAgronegocios.Entities;
using System;
using System.Collections.Generic;
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
    }
}
