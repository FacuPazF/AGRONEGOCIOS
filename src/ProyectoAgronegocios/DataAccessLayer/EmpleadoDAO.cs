using ProyectoAgronegocios.Entities;
using System;
using System.Data;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class EmpleadoDAO

    {
        private string consulta;

        public static Empleado GetEmpleado(string nombreEmpleado)
        {
            string cSQL = "SELECT cod_Empleado, nombre, apellido, email, telefono, fecha_Alta, cod_barrio, calle, numero_casa, fecha_nacimiento, tipo_Empleado, contraseña, usuario, borrado FROM Empleados WHERE borrado = 0 AND usuario = '" + nombreEmpleado + "'";


            DataTable dt = DBHelper.consultar(cSQL);
            if (dt.Rows.Count > 0)
            {
                int cod_Empleado = Convert.ToInt32(dt.Rows[0]["cod_Empleado"].ToString());
                string nombre = dt.Rows[0]["nombre"].ToString();
                string apellido = dt.Rows[0]["apellido"].ToString();
                string email = dt.Rows[0]["email"].ToString();
                string telefono = dt.Rows[0]["telefono"].ToString();
                DateTime fecha_Alta = Convert.ToDateTime(dt.Rows[0]["fecha_Alta"]);
                int cod_barrio = Convert.ToInt32(dt.Rows[0]["cod_barrio"].ToString());
                string calle = dt.Rows[0]["calle"].ToString();
                string numero_casa = dt.Rows[0]["numero_casa"].ToString();
                DateTime fecha_nacimiento = Convert.ToDateTime(dt.Rows[0]["fecha_nacimiento"]);
                int tipo_Empleado = Convert.ToInt32(dt.Rows[0]["tipo_empleado"].ToString());
                string contraseña = dt.Rows[0]["contraseña"].ToString();
                string usuario = dt.Rows[0]["usuario"].ToString();
                int borrado = Convert.ToInt32(dt.Rows[0]["borrado"]);

                return new Empleado(cod_Empleado, nombre, apellido, email, telefono, fecha_Alta, cod_barrio, calle, numero_casa, fecha_nacimiento, tipo_Empleado, contraseña, usuario, borrado);
            }

            return null;
        }

        public DataTable consultarEmpleadosSinParametros()
        {
            consulta = "SELECT" +
                    " e.cod_Empleado as 'COD'," +
                    " te.nombre as 'Tipo Empleado'," +
                    " e.nombre as 'Nombre'," +
                    " e.apellido as 'Apellido'," +
                    " e.email as 'Email'," +
                    " e.telefono as 'Telefono'," +
                    " e.calle as 'Calle'," +
                    " e.numero_casa as 'NroCasa'," +
                    " b.nombre as 'Barrio'," +
                    " e.fecha_nacimiento as 'Fecha Nacimiento'" +
                " FROM Empleados e" +
                " JOIN Barrios b ON e.cod_barrio = b.id_Barrio" +
                " JOIN Tipo_Empleados te ON e.tipo_Empleado = te.id_tipo_Empleado" +
                " WHERE e.borrado = 0";

            return DBHelper.consultar(consulta);
        }

        public DataTable consultarEmpleadoConCod(string cod)
        {
            consulta = "SELECT" +
                   " e.cod_Empleado as 'COD'," +
                   " te.nombre as 'Tipo Empleado'," +
                   " e.nombre as 'Nombre'," +
                   " e.apellido as 'Apellido'," +
                   " e.email as 'Email'," +
                   " e.telefono as 'Telefono'," +
                   " e.calle as 'Calle'," +
                   " e.numero_casa as 'NroCasa'," +
                   " b.nombre as 'Barrio'," +
                   " e.fecha_nacimiento as 'Fecha Nacimiento'" +
               " FROM Empleados e" +
               " JOIN Barrios b ON e.cod_barrio = b.id_Barrio" +
               " JOIN Tipo_Empleados te ON e.tipo_Empleado = te.id_tipo_Empleado" +
               " WHERE e.borrado = 0 AND e.cod_Empleado LIKE '" + cod + "'";
            DataTable tabla = DBHelper.consultar(consulta);
            if (tabla.Rows.Count != 0)
                return tabla;
            return new DataTable();
        }

        public DataTable recuperarDatosEmpleado(int cod)
        {
            consulta = "SELECT" +
                   " te.id_tipo_Empleado as 'Tipo Empleado'," +
                   " b.id_Barrio as 'Barrio'," +
                   " e.nombre as 'Nombre'," +
                   " e.apellido as 'Apellido'," +
                   " e.email as 'Email'," +
                   " e.telefono as 'Telefono'," +
                   " e.calle as 'Calle'," +
                   " e.numero_casa as 'NroCasa'," +
                   " e.fecha_nacimiento as 'Fecha Nacimiento'" +
               " FROM Empleados e" +
               " JOIN Barrios b ON e.cod_barrio = b.id_Barrio" +
               " JOIN Tipo_Empleados te ON e.tipo_Empleado = te.id_tipo_Empleado" +
               " WHERE e.borrado = 0 AND e.cod_Empleado = " + cod.ToString();
            return DBHelper.consultar(consulta);
        }

        public void borrarEmpleado(int cod)
        {
            consulta = "UPDATE Empleados " +
                "SET borrado = 1 " +
                "WHERE cod_Empleado = " + cod;

            DBHelper.actualizar(consulta);
        }

        public void registrarEmpleado(Empleado emp)
        {
            consulta = "INSERT INTO Empleados (nombre, apellido, email, telefono, fecha_Alta, cod_Barrio, calle, numero_casa, fecha_nacimiento, tipo_Empleado, borrado) " +
                "VALUES ( '" +
                emp.Nombre + "', '" +
                emp.Apellido + "', '" +
                emp.Email + "', '" +
                emp.Telefono + "', '" +
                emp.Fecha_Alta.ToString("yyyy-MM-dd") + "', " +
                emp.Cod_barrio + ", '" +
                emp.Calle + "', '" +
                emp.Numero_casa + "', '" +
                emp.Fecha_nacimiento.ToString("yyyy-MM-dd") + "', " +
                emp.Tipo_Empleado + ", " +
                emp.Borrado + ")";

            DBHelper.actualizar(consulta);
        }

        public void modificarEmpleado(Empleado emp)
        {
            consulta = "UPDATE Empleados " +
                "SET " +
                "nombre = '" + emp.Nombre + "', " +
                "apellido = '" + emp.Apellido + "', " +
                "email = '" + emp.Email + "', " +
                "telefono = '" + emp.Telefono + "', " +
                "fecha_Alta = '" + emp.Fecha_Alta.ToString("yyyy-MM-dd") + "', " +
                "cod_Barrio = " + emp.Cod_barrio + ", " +
                "calle = '" + emp.Calle + "', " +
                "numero_casa = '" + emp.Numero_casa + "', " +
                "fecha_nacimiento = '" + emp.Fecha_nacimiento.ToString("yyyy-MM-dd") + "', " +
                "tipo_Empleado = " + emp.Tipo_Empleado + " " +
                "WHERE cod_Empleado = " + emp.Cod_Empleado;

            DBHelper.actualizar(consulta);

        }

        public DataTable buscarAntiguedades(DateTime fd, DateTime fh)
        {
            string consulta;
            consulta = "SELECT cod_Empleado AS Codigo, nombre AS Nombre, apellido AS Apellido, " + 
                       " DATEDIFF(day, fecha_Alta, CONVERT(varchar, GETDATE(), 23)) AS DiffDias, " + 
                       " DATEDIFF(MM, fecha_Alta, CONVERT(varchar, GETDATE(), 23)) AS DiffMeses " + 
                       " FROM Empleados" +
                       " WHERE borrado = 0 AND tipo_Empleado = 2" +
                       " AND (fecha_Alta BETWEEN '" + fd.ToString("yyyy-MM-dd") + "' AND '" + fh.ToString("yyyy-MM-dd") + "')";

            return DataManager.GetInstance().ConsultaSQL(consulta);
        }
    }
}