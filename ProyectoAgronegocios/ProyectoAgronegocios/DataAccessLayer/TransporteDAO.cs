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
                    " t.direccion as 'Direccion'," +
                    " b.nombre as 'Barrio'" +
                " FROM Empresa_Transporte t" +
                " JOIN Barrios b ON t.id_barrio = b.id_Barrio" +
                " WHERE t.borrado = 0 ";
            return DBHelper.consultar(consulta);
        }
        public DataTable ConsultarTransporteConRazonSocial(string rs)
        {
            consulta = "SELECT" +
                 " t.id_Empresa as 'ID Empresa'," +
                    " t.descripcion as 'Descripcion'," +
                    " t.razon_social as 'Razon Social'," +
                    " t.telefono as 'Telefono'," +
                    " t.direccion as 'Direccion'," +
                    " b.nombre as 'Barrio'" +
                " FROM Empresa_Transporte t" +
                " JOIN Barrios b ON t.id_barrio = b.id_Barrio" +
                " WHERE t.borrado = 0 AND t.razon_social LIKE '" + rs + "'";
            DataTable tabla = DBHelper.consultar(consulta);
            if (tabla.Rows.Count != 0)
                return tabla;
            return new DataTable();
        }

        public DataTable RecuperarDatosTransporte(int id)
        {
            consulta = "SELECT" +
                    " t.descripcion as 'Descripcion'," +
                    " t.razon_social as 'Razon Social'," +
                    " t.telefono as 'Telefono'," +
                    " t.direccion as 'Direccion'," +
                    " b.id_Barrio as 'Barrio'" +
                " FROM Empresa_Transporte t" +
                " JOIN Barrios b ON t.id_barrio = b.id_Barrio" +
                " WHERE t.borrado = 0 and t.id_Empresa = " + id.ToString();
            return DBHelper.consultar(consulta);
        }

        public void RegistrarTransporte(Transporte transporte)
        {
            consulta = "INSERT INTO Empresa_Transporte (descripcion, razon_social, telefono, direccion, id_barrio, borrado) " +
                "VALUES ( '" +
                transporte.Descripcion + "', '" +
                transporte.Razon_social + "', '" +
                transporte.Telefono + "', '" +
                transporte.Direccion + "', '" +
                transporte.Id_barrio + "', " +
                transporte.Borrado + ")";

            DBHelper.actualizar(consulta);

        }

        public void ModificarTransporte(Transporte transporte)
        {
            consulta = "UPDATE Empresa_Transporte " +
                "SET " +
                "descripcion = '" + transporte.Descripcion + "', " +
                "razon_social = '" + transporte.Razon_social + "', " +
                "telefono = '" + transporte.Telefono + "', " +
                "direccion = '" + transporte.Direccion + "', " +
                "id_barrio = " + transporte.Id_barrio + 
                " WHERE id_Empresa = " + transporte.Id_Empresa;


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
