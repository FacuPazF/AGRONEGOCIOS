using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class SemillaDAO
    {
        private string consultaSQL;

        // ----------------------------- Consultas
        public DataTable consultarSemillasSinParametros()
        {
            consultaSQL = "SELECT " +
                          "  s.id_Semilla AS 'ID'," +
	                      "  s.nombre AS 'Nombre'," +
	                      "  s.stock AS 'Stock',"   +
	                      "  s.precio_Tonelada AS 'Precio Por Tonelada'," +
	                      "  ts.nombre AS 'Tipo de Semilla',"  +
	                      "  c.nombre AS 'Calidad'" +
                        "FROM Semilla s "+
                        "JOIN TiposXsemillas tp ON s.id_Semilla = tp.id_Semilla "+
                        "JOIN Tipo_Semilla ts ON tp.id_Tipo_Semilla = ts.id_Tipo_Semilla "+ 
                        "JOIN Calidad c ON tp.id_Calidad = c.id_Calidad "+
                        "WHERE s.borrado = 0"; 
            return DataManager.GetInstance().ConsultaSQL(consultaSQL);
        }
        public DataTable consultarSemillasConFiltros(string condiciones)
        {
            consultaSQL = "SELECT " +
                          "  s.id_Semilla AS 'ID'," +
                          "  s.nombre AS 'Nombre'," +
                          "  s.stock AS 'Stock'," +
                          "  s.precio_Tonelada AS 'Precio Por Tonelada'," +
                          "  ts.nombre AS 'Tipo de Semilla'," +
                          "  c.nombre AS 'Calidad'" +
                        "FROM Semilla s " +
                        "JOIN TiposXsemillas tp ON s.id_Semilla = tp.id_Semilla " +
                        "JOIN Tipo_Semilla ts ON tp.id_Tipo_Semilla = ts.id_Tipo_Semilla " +
                        "JOIN Calidad c ON tp.id_Calidad = c.id_Calidad " +
                        "WHERE s.borrado = 0" +
                        condiciones;

            return DataManager.GetInstance().ConsultaSQL(consultaSQL);
        }
        public DataTable recuperarSemillasPorID(int id)
        {
            consultaSQL = "SELECT "
                            +" s.nombre AS 'Nombre',"
	                        +" s.stock_Minimo AS 'Stock Minimo',"
	                        +" s.stock AS 'Stock',"
	                        +" s.precio_Tonelada AS 'Precio Por Tonelada',"
	                        +" s.habilitado AS 'Habilitado',"
	                        +" s.descripcion AS 'Descripcion',"
	                        +" tp.precio_sugerido AS 'Precio Sugerido',"
	                        + " ts.id_Tipo_Semilla AS 'Tipo de Semilla',"
                            + " c.id_Calidad AS 'Calidad'"
                        + " FROM Semilla s"
                        +" JOIN TiposXsemillas tp ON s.id_Semilla = tp.id_Semilla"
                        +" JOIN Tipo_Semilla ts ON tp.id_Tipo_Semilla = ts.id_Tipo_Semilla"
                        +" JOIN Calidad c ON tp.id_Calidad = c.id_Calidad"
                        +" WHERE s.borrado = 0 AND s.id_Semilla = " + id.ToString();
            
            return DataManager.GetInstance().ConsultaSQL(consultaSQL);
        }
    }
}
