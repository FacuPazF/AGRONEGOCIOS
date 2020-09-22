using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.Entities;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class TransporteDAO
    {
        private string consulta;

        public DataTable ConsultarTransporteSinParametros()
        {
            consulta = "SELECT" +
                    " t.id_Empresa as 'ID Empresa'," +
                    " t.descripcion as 'Descripcion'," +
                    " t.razon_social as 'Razon Social'," +
                    " t.telefono as 'Telefono'," +
                    " t.direccion as 'Dirreccion'," +
                    " b.nombre as 'Barrio'" +
                " FROM Empresa_Transporte t" +
                " JOIN Barrios b ON t.id_barrio = b.id_Barrio" +
                " WHERE t.borrado = 0 ";
            return DBHelper.consultar(consulta);
        }
        public DataTable ConsultarClientesConRazonSocial(string rs)
        {
            consulta = "SELECT" +
                 " t.id_Empresa as 'ID Empresa'," +
                    " t.descripcion as 'Descripcion'," +
                    " t.razon_social as 'Razon Social'," +
                    " t.telefono as 'Telefono'," +
                    " t.direccion as 'Dirreccion'," +
                    " b.nombre as 'Barrio'" +
                " FROM Empresa_Transporte t" +
                " JOIN Barrios b ON t.id_barrio = b.id_Barrio" +
                " WHERE t.borrado = 0 AND t.razon_social LIKE '" + rs + "'";
            DataTable tabla = DBHelper.consultar(consulta);
            if (tabla.Rows.Count != 0)
                return tabla;
            return new DataTable();
        }

        public DataTable RecuperarDatosCliente(int id)
        {
            consulta = "SELECT" +
                    " t.descripcion as 'Descripcion'," +
                    " t.razon_social as 'Razon Social'," +
                    " t.telefono as 'Telefono'," +
                    " t.direccion as 'Dirreccion'," +
                    " b.nombre as 'Barrio'" +
                " FROM Empresa_Transporte t" +
                " JOIN Barrios b ON t.id_barrio = b.id_Barrio" +
                " WHERE t.borrado = 0 and t.id_Empresa = " + id.ToString();
            return DBHelper.consultar(consulta);
        }

        public void RegistrarTransporte(Transporte transporte)
        {
            consulta = "INSERT INTO Empresa_Transporte (descripcion, razon_social, telefono, direccion, cod_Barrio, borrado) " +
                "VALUES ( '" +
                transporte.descripcion + "', '" +
                transporte.razon_social + "', '" +
                transporte.telefono + "', '" +
                transporte.direccion + "', '" +
                transporte.cod_Barrio + "', " +
                transporte.Borrado + ")";

            DBHelper.actualizar(consulta);

        }

        public void ModificarTransporte(Transporte transporte)
        {
            consulta = "UPDATE Empresa_Transporte " +
                "SET " +
                "descripcion = '" + transporte.descripcion + "', " +
                "razon_social = '" + transporte.Razon_Social + "', " +
                "telefono = '" + transporte.telefono + "', " +
                "direccion = '" + transporte.direccion + "', " +
                "id_barrio = " + transporte.id_Barrio + ", " +
                "WHERE id_Empresa = " + transporte.id_Empresa;


            DBHelper.actualizar(consulta);
        }
        public void BorrarTransporte(int id)
        {
            consulta = "UPDATE Empresa_Transporte " +
                "SET borrado = 1 " +
                "WHERE id_Empresa = " + id;


            DBHelper.actualizar(consulta);
        }
    }
}
