using ProyectoAgronegocios.Entities;
using System;
using System.Collections.Generic;
using System.Data;
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
    
        public DataTable buscarFacturasPorCliente(int id_Cliente)
        {
            string consulta;
            consulta = "SELECT "
                        + "f.tipo_Factura AS 'Tipo de Factura', "
                        + "f.numero AS 'Numero de Factura', "
                        + "f.fecha_Factura AS 'Fecha de Emision', "
                        + "f.total AS 'Monto Total', "
                        + "f.cod_Empleado AS 'Empleado' "
                        + "FROM Facturas f "
                        + "JOIN Cliente_Proveedor c ON f.id_cliente_Proveedor = c.id_Cliente_Proveedor " 
                        + "LEFT JOIN Envios e ON (e.id_Factura = f.numero AND e.tipo_Factura = f.tipo_Factura) "
                        + "WHERE c.id_Cliente_Proveedor = " + id_Cliente
                        + "AND e.id_Factura IS NULL"  ;
            return DataManager.GetInstance().ConsultaSQL(consulta);
        }

        public DataTable recuperarDetalles(int num, string tipo_factura)
        {
            string consulta;
            consulta = "SELECT " +
                       "s.nombre AS 'nombreSemilla', " +
                       "df.cantidad AS 'cantidad', " +
                       "df.precio_Venta AS 'precio', " +
                       "df.subtotal AS 'subtotal' " +
                       "FROM Facturas f " +
                       "JOIN Detalles_de_Facturas df " +
                       "ON (f.tipo_Factura = df.tipo_Factura AND f.numero = df.numero_Factura) " +
                       "JOIN Semilla s " +
                       "ON df.id_Semilla = s.id_Semilla " +
                       "WHERE f.tipo_Factura = '" + tipo_factura + "' AND f.numero = " + num;

            return DataManager.GetInstance().ConsultaSQL(consulta);

        }

        public DataTable buscarFacturasConParametros(DateTime fd, DateTime fh, string tf, int idc)
        {
            string consulta;
            consulta = "SELECT * FROM Facturas" +
                       " WHERE (fecha_Factura BETWEEN '" + fd.ToString("yyyy-MM-dd") + "' AND '" + fh.ToString("yyyy-MM-dd") + "')" + 
                       " AND tipo_Factura = '" + tf + "'" +
                       " AND id_cliente_Proveedor = " + idc;

            return DataManager.GetInstance().ConsultaSQL(consulta);
        }

        public DataTable buscarDetFacturasReporte(DateTime fd, DateTime fh, int idc)
        {
            string consulta;
            consulta = "SELECT c.nombre, s.nombre as Expr1, ts.nombre as Expr2, SUM(df.cantidad) as Expr3" +
                       " FROM Facturas f " +
                       " JOIN Detalles_de_Facturas df ON f.tipo_Factura = df.tipo_Factura AND f.numero = df.numero_Factura " +
                       " JOIN Semilla s ON df.id_Semilla = s.id_Semilla " +
                       " JOIN TiposXsemillas txs ON s.id_Semilla = txs.id_Semilla " +
                       " JOIN Calidad c ON txs.id_Calidad = c.id_Calidad " +
                       " JOIN Tipo_Semilla ts ON txs.id_Tipo_Semilla = ts.id_Tipo_Semilla " +
                       " WHERE f.id_cliente_Proveedor = " + idc +
                       " AND (f.fecha_Factura BETWEEN '" + fd.ToString("yyyy-MM-dd") + "' AND '" + fh.ToString("yyyy-MM-dd") + "')" +
                       " AND s.borrado = 0" +
                       " GROUP BY s.nombre, ts.nombre, c.nombre";

            return DataManager.GetInstance().ConsultaSQL(consulta);
        }

        public DataTable buscarVentasEmpleado(DateTime fd, DateTime fh)
        {
            string consulta;
            consulta = "SELECT e.cod_Empleado AS Codigo, e.nombre AS Nombre, e.apellido AS Apellido, COUNT(f.numero) AS Cantidad" +
                       " FROM Facturas f " +
                       " JOIN Empleados e ON f.cod_Empleado = e.cod_Empleado " +
                       " WHERE (f.fecha_Factura BETWEEN '" + fd.ToString("yyyy-MM-dd") + "' AND '" + fh.ToString("yyyy-MM-dd") + "')" +
                       " AND e.borrado = 0 " +
                       " AND e.tipo_Empleado = 2" +
                       " GROUP BY e.cod_Empleado, e.nombre, e.apellido";

            return DataManager.GetInstance().ConsultaSQL(consulta);
        }
    }


}
