using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.Entities
{
    class Transporte
    {
        private int id_Empresa;
        private string descripcion;
        private string razon_social;
        private string telefono;
        private string direccion;
        private int id_barrio;
        private int borrado;

        public Transporte(int id_Empresa, string descripcion, string razon_social, string telefono, string direccion, int id_barrio, int borrado)
        {
            this.Id_Empresa = id_Empresa;
            this.Descripcion = descripcion;
            this.Razon_social = razon_social;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.id_barrio = id_barrio;
            this.Borrado = borrado;
        }
        public Transporte()
        {
            this.Id_Empresa = -1;
            this.Descripcion = "";
            this.Razon_social = "";
            this.Telefono = "";
            this.Direccion = "";
            this.Id_barrio = -1;
            this.Borrado = 0;
        }

        public int Id_Empresa { get => id_Empresa; set => id_Empresa = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Razon_social { get => razon_social; set => razon_social = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Id_barrio { get => id_barrio; set => id_barrio = value; }
        public int Borrado { get => borrado; set => borrado = value; }
    }
}

