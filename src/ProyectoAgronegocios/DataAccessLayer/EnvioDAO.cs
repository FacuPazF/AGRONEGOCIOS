using System;
using System.Collections.Generic;
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
    }
}
