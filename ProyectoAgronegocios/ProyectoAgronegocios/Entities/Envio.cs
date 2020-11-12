using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.Entities
{
    class Envio
    {
        private int id_Factura;
        private string tipo_Factura;
        private int nro_envio;
        private DateTime fecha_Hora_envio;
        private int id_Empresa_Transporte;
        private string direccion;
        private int id_barrio;

        public int Id_Factura { get => id_Factura; set => id_Factura = value; }
        public string Tipo_Factura { get => tipo_Factura; set => tipo_Factura = value; }
        public int Nro_envio { get => nro_envio; set => nro_envio = value; }
        public DateTime Fecha_Hora_envio { get => fecha_Hora_envio; set => fecha_Hora_envio = value; }
        public int Id_Empresa_Transporte { get => id_Empresa_Transporte; set => id_Empresa_Transporte = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Id_barrio { get => id_barrio; set => id_barrio = value; }

        public Envio(int id_Factura, string tipo_Factura, int nro_envio, DateTime fecha_Hora_envio, int id_Empresa_Transporte, string direccion, int id_barrio)
        {
            this.id_Factura = id_Factura;
            this.tipo_Factura = tipo_Factura;
            this.nro_envio = nro_envio;
            this.fecha_Hora_envio = fecha_Hora_envio;
            this.id_Empresa_Transporte = id_Empresa_Transporte;
            this.direccion = direccion;
            this.id_barrio = id_barrio;
        }

        public Envio()
        {
            this.id_Factura = -1;
            this.tipo_Factura = "";
            this.nro_envio = -1;
            this.fecha_Hora_envio = DateTime.Today;
            this.id_Empresa_Transporte = -1;
            this.direccion = "";
            this.id_barrio = -1;
        }



    }
}
