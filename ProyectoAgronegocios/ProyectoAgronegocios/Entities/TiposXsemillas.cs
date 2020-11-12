using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.Entities
{
    class TiposXsemillas
    {
        private int id_semilla;
        private int id_tipo_semilla;
        private int id_calidad;
        private double precio_sugerido;

        public TiposXsemillas(int id_semilla, int id_tipo_semilla, int id_calidad, double precio_sugerido)
        {
            this.id_semilla = id_semilla;
            this.id_tipo_semilla = id_tipo_semilla;
            this.id_calidad = id_calidad;
            this.precio_sugerido = precio_sugerido;
        }

        public TiposXsemillas()
        {
            this.id_semilla = -1;
            this.id_tipo_semilla = -1;
            this.id_calidad = -1;
            this.precio_sugerido = 0;
        }

        public int Id_semilla { get => id_semilla; set => id_semilla = value; }
        public int Id_tipo_semilla { get => id_tipo_semilla; set => id_tipo_semilla = value; }
        public int Id_calidad { get => id_calidad; set => id_calidad = value; }
        public double Precio_sugerido { get => precio_sugerido; set => precio_sugerido = value; }
    }
}
