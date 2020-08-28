using ProyectoAgronegocios.DataAccessLayer;
using ProyectoAgronegocios.Entities;

namespace ProyectoAgronegocios.BusinessLayer
{
    static class EmpleadoService
    {

        public static Empleado validarUsuario(string usuario, string clave)
        {
            Empleado user = EmpleadoDAO.GetEmpleado(usuario);
            if (user != null && user.Contraseña.Equals(clave))
            {
                return user;
            }

            return null;
        }
    }
}
