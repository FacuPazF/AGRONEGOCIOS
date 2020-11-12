using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.Entities;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class EnvioDAO
    {
        

        public void registrarEnvio(Envio env)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();


                string cSQL = "INSERT INTO Envios (id_Factura, tipo_Factura, fecha_Hora_envio, id_Empresa_Transporte, direccion, id_barrio) " +
                              "VALUES (" +
                              env.Id_Factura + ", '" +
                              env.Tipo_Factura + "', '" + 
                              env.Fecha_Hora_envio.ToString("yyyy-MM-dd") + "', " + 
                              env.Id_Empresa_Transporte + ", '" +
                              env.Direccion + "', " +
                              env.Id_barrio + ")";
                dm.EjecutarSQL(cSQL);

                
                cSQL = "UPDATE Detalles_de_Facturas SET fecha_Entrega = '" + env.Fecha_Hora_envio.ToString("yyyy-MM-dd") + "' WHERE tipo_Factura = '" + env.Tipo_Factura + "' AND numero_Factura = " + env.Id_Factura;
                dm.EjecutarSQL(cSQL);

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

        public DataTable buscarEnviosProv(DateTime fd, DateTime fh)
        {
            string consulta;
            consulta = "SELECT p.nombre AS Nombre, COUNT(e.nro_envio) AS Cantidad" + 
                       " FROM Barrios b " +
                       " JOIN Localidad l ON b.id_Localidad = l.id_Localidad " +
                       " JOIN Provincia p ON l.id_Provincia = p.id_Provincia " +
                       " JOIN Envios e ON b.id_Barrio = e.id_barrio " +
                       " WHERE (e.fecha_Hora_envio BETWEEN '" + fd.ToString("yyyy-MM-dd") + "' AND '" + fh.ToString("yyyy-MM-dd") + "')" + 
                       " GROUP BY p.nombre";

            return DataManager.GetInstance().ConsultaSQL(consulta);

        }

        public DataTable buscarEnviosEmpresa(DateTime fd, DateTime fh)
        {
            string consulta;
            consulta = "SELECT et.id_Empresa, et.razon_social, COUNT(e.nro_envio) AS Expr1 " +
                       " FROM Envios e " +
                       " JOIN Empresa_Transporte et ON e.id_Empresa_Transporte = et.id_Empresa " + 
                       " WHERE(e.fecha_Hora_envio BETWEEN '" + fd.ToString("yyyy-MM-dd") + "' AND '" + fh.ToString("yyyy-MM-dd") + "')" +
                       " GROUP BY et.id_Empresa, et.razon_social";

            return DataManager.GetInstance().ConsultaSQL(consulta);
        }

        public DataTable recuperarVentasProv(DateTime fd, DateTime fh)
        {
            string consulta;
            consulta = "SELECT p.nombre, (SUM(f.total)/(SELECT SUM(f.total) FROM Facturas f JOIN Envios e ON (f.numero = e.id_Factura AND f.tipo_Factura = e.tipo_Factura)  ) * 100) as Porc" +
                        " FROM Facturas f  " +
                        " JOIN Envios e ON (f.numero = e.id_Factura AND f.tipo_Factura = e.tipo_Factura) " +
                        " JOIN Barrios b ON (e.id_barrio = b.id_Barrio) " +
                        " JOIN Localidad l ON (b.id_Localidad = l.id_Localidad) " +
                        " JOIN Provincia p ON (l.id_Provincia = p.id_Provincia) " +
                        " WHERE f.fecha_Factura BETWEEN '" + fd.ToString("yyyy-MM-dd") + "' AND '" + fh.ToString("yyyy-MM-dd") + "' " +
                        " GROUP BY p.nombre";
            return DataManager.GetInstance().ConsultaSQL(consulta);
        }

        public DataTable recuperarEnviosEmp(DateTime fd, DateTime fh)
        {
            string consulta;
            consulta = " SELECT emp.id_Empresa, emp.razon_social, COUNT(env.nro_envio) as CantEnvios" +
                       " FROM Envios env" +
                       " JOIN Empresa_Transporte emp ON env.id_Empresa_Transporte = emp.id_Empresa " +
                       " WHERE emp.borrado = 0" +
                       " GROUP BY emp.id_Empresa, emp.razon_social"+
                       " ORDER BY CantEnvios";

            return DataManager.GetInstance().ConsultaSQL(consulta);
        }
       

    }
}
