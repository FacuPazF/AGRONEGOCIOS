using ProyectoAgronegocios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.Support
{
    class Sesion
    {
        private Empleado user = new Empleado();
        private static Sesion instance = new Sesion();

        internal Empleado User { get => user; set => user = value; }

        public static Sesion GetInstance()
        {
            if (instance == null)
                instance = new Sesion();

            

            return instance;
        }
        public Sesion()
        {
            
        }
    }
}
