using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class ClienteDAO
    {
        private string consulta;
        public DataTable consultarClientesSinParametros()
        {
            consulta = "SELECT" +
	                " c.id_Cliente_Proveedor as 'ID'," +
	                " c.CUIL_CUIT as 'Cuil o Cuit'," +
	                " c.nombre as 'Nombre'," +
	                " c.apellido as 'Apellido'," +
	                " c.razon_Social as 'Razon Social'," +
	                " tc.nombre as 'Tipo de Cliente'," +
	                " c.email as 'Email'," +
	                " c.telefono as 'Telefono'," +
	                " b.nombre as 'Barrio'" +
                " FROM Cliente_Proveedor c" +
                " JOIN Barrios b ON c.cod_Barrio = b.id_Barrio" +
                " JOIN Tipo_Cliente_Proveedor tc ON c.id_Tipo = tc.id_Tipo" +
                " WHERE c.borrado = 0" ;
            return DBHelper.consultar(consulta);
        }
    }
}
