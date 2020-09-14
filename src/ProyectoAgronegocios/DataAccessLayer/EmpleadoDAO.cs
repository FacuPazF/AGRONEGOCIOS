using ProyectoAgronegocios.Entities;
using System;
using System.Data;

namespace ProyectoAgronegocios.DataAccessLayer
{
    static class EmpleadoDAO
    {
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
                int telefono = Convert.ToInt32(dt.Rows[0]["telefono"].ToString());
                DateTime fecha_Alta = Convert.ToDateTime(dt.Rows[0]["fecha_Alta"]);
                int cod_barrio = Convert.ToInt32(dt.Rows[0]["cod_barrio"].ToString());
                string calle = dt.Rows[0]["calle"].ToString();
                int numero_casa = Convert.ToInt32(dt.Rows[0]["numero_casa"].ToString());
                DateTime fecha_nacimiento = Convert.ToDateTime(dt.Rows[0]["fecha_nacimiento"]);
                int tipo_Empleado = Convert.ToInt32(dt.Rows[0]["tipo_empleado"].ToString());
                string contraseña = dt.Rows[0]["contraseña"].ToString();
                string usuario = dt.Rows[0]["usuario"].ToString();
                int borrado = Convert.ToInt32(dt.Rows[0]["borrado"]);
                
                return new Empleado(cod_Empleado, nombre, apellido, email, telefono, fecha_Alta, cod_barrio, calle, numero_casa, fecha_nacimiento, tipo_Empleado, contraseña, usuario, borrado);
            }

            return null;
        }
    }
}
