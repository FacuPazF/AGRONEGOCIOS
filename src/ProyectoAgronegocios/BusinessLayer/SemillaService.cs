using ProyectoAgronegocios.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.Entities;

namespace ProyectoAgronegocios.BusinessLayer
{
    class SemillaService
    {
        private SemillaDAO daoSemilla = new SemillaDAO();
        
        // ------------------- Consultas
        public DataTable consultarSemillasSinParametros()
        {
            return daoSemilla.consultarSemillasSinParametros();
        }

        public DataTable consultarSemillasConFiltros(string condiciones)
        {
            return daoSemilla.consultarSemillasConFiltros(condiciones);
        }

        public DataTable recuperarSemillasPorID(int id)
        {
            return daoSemilla.recuperarSemillasPorID(id);
        }


        // --------------------- Alta
        public void crearNuevaSemilla(Semilla semilla,TiposXsemillas tipos_x_semillas)
        {
           this.daoSemilla.crearNuevaSemilla(semilla, tipos_x_semillas);
        }

        // ------------------- Modificacion
        public void modificarSemilla(Semilla semilla, TiposXsemillas tipos_x_semillas)
        {
            daoSemilla.modificarSemilla(semilla, tipos_x_semillas);
        }

        // ------------------  Baja
        public void borrarSemilla(int id)
        {
            daoSemilla.borrarSemilla(id);
        }

        public DataTable recuperarVentasSemilla(DateTime fd, DateTime fh) => daoSemilla.recuperarVentasSemilla(fd, fh);
        

    }
}
