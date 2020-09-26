using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.Entities
{
    class Factura
    {
        private string tipo_factura;
        private int numero;
        private DateTime fecha_Factura;
        private double total;
        private int cod_Empleado;
        private int id_cliente;

        public Factura(string tipo_factura, int numero, DateTime fecha_Factura, double total, int cod_Empleado, int id_cliente)
        {
            this.tipo_factura = tipo_factura;
            this.numero = numero;
            this.fecha_Factura = fecha_Factura;
            this.total = total;
            this.cod_Empleado = cod_Empleado;
            this.id_cliente = id_cliente;
        }
        public Factura()
        {
            this.tipo_factura = "";
            this.numero = -1;
            this.fecha_Factura = DateTime.Today;
            this.total = 0;
            this.cod_Empleado = -1;
            this.id_cliente = -1;
        }

        public string Tipo_factura { get => tipo_factura; set => tipo_factura = value; }
        public int Numero { get => numero; set => numero = value; }
        public double Total { get => total; set => total = value; }
        public int Cod_Empleado { get => cod_Empleado; set => cod_Empleado = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public DateTime Fecha_Factura { get => fecha_Factura; set => fecha_Factura = value; }
    }
}
