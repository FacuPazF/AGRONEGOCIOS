using ProyectoAgronegocios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class FacturaDAO
    {
       
        public void InsertarFactura(Factura fact, List<DetalleFactura> lista, List<FormaPagoXfactura> lista_FP)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();


                string cSQL = "INSERT INTO Facturas (tipo_Factura, fecha_Factura, total, cod_Empleado, id_cliente_Proveedor) VALUES"
                                 + " ('"
                                 + fact.Tipo_factura + "', '"
                                 + fact.Fecha_Factura.ToString("yyyy-MM-dd") + "', "
                                 + (fact.Total).ToString().Replace(",",".") + ", "
                                 + fact.Cod_Empleado + ", "
                                 + fact.Id_cliente + ")";
                dm.EjecutarSQL(cSQL);

                int id_Factura = Convert.ToInt32(dm.ConsultaSQLScalar("SELECT @@IDENTITY AS 'PK_Factura'"));

                for (int i = 0; i < lista.Count; i++)
                {
                    cSQL = "INSERT INTO Detalles_de_Facturas (tipo_Factura, id_Semilla, numero_Factura, precio_Venta, cantidad, subtotal) VALUES"
                           + " ('"
                           + lista[i].Tipo_Factura + "', "
                           + lista[i].Id_Semilla + ", "
                           + id_Factura + ", "
                           + lista[i].Precio_Venta.ToString().Replace(",", ".") + ", "
                           + lista[i].Cantidad + ", "
                           + lista[i].Subtotal.ToString().Replace(",", ".") + " )";
                    dm.EjecutarSQL(cSQL);

                }
                for (int i = 0; i < lista_FP.Count; i++)
                {
                    cSQL = "INSERT INTO Forma_PagoXfactura (id_Forma_Pago, tipo_Factura, numero_Factura, monto, dias_de_Plazo) VALUES "
                           + " ("
                           + lista_FP[i].Id_Forma_Pago + ", '"
                           + lista_FP[i].Tipo_Factura + "', "
                           + id_Factura + ", "
                           + lista_FP[i].Monto.ToString().Replace(",", ".") + ", "
                           + lista_FP[i].Dias_de_Plazo + ")";
                           
                    dm.EjecutarSQL(cSQL);

                }
                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                dm.Close();
            }
        }
    }
}
