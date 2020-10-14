using ProyectoAgronegocios.DataAccessLayer;
using ProyectoAgronegocios.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.BusinessLayer
{
    class EmpleadoService
    {
        private EmpleadoDAO daoEmpleado = new EmpleadoDAO();

        public static Empleado validarUsuario(string usuario, string clave)
        {
            Empleado user = EmpleadoDAO.GetEmpleado(usuario);
            if (user != null && user.Contraseña.Equals(clave))
            {
                return user;
            }

            return null;
        }

        public DataTable consultarEmpleadosSinParametros()
        {
            return daoEmpleado.consultarEmpleadosSinParametros();
        }

        public DataTable consultarEmpleadoConCod(string cod)
        {
            return daoEmpleado.consultarEmpleadoConCod(cod);
        }

        public DataTable recuperarDatosEmpleado(int cod)
        {
            return daoEmpleado.recuperarDatosEmpleado(cod);
        }


        public void borrarEmpleado(int cod)
        {
            daoEmpleado.borrarEmpleado(cod);
        }

        public void registrarEmpleado(Empleado emp)
        {
            daoEmpleado.registrarEmpleado(emp);
        }

        public void modificarEmpleado(Empleado emp)
        {
            daoEmpleado.modificarEmpleado(emp);
        }

        public DataTable buscarAntiguedades(DateTime fd, DateTime fh)
        {
            return daoEmpleado.buscarAntiguedades(fd, fh);
        }
    }
}
