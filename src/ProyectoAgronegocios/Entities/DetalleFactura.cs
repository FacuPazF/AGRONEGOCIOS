using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.Entities
{
    class DetalleFactura
    {
        private int id_Semilla;
        private string tipo_Factura;
        private int numero_Factura;
        private DateTime fecha_Entrega;
        private double precio_Venta;
        private int cantidad;
        private double subtotal;

        public DetalleFactura(int id_Semilla, string tipo_Factura, int numero_Factura, DateTime fecha_Entrega, double precio_Venta, int cantidad, double subtotal)
        {
            this.id_Semilla = id_Semilla;
            this.tipo_Factura = tipo_Factura;
            this.numero_Factura = numero_Factura;
            this.fecha_Entrega = fecha_Entrega;
            this.precio_Venta = precio_Venta;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }

        public DetalleFactura()
        {
            this.id_Semilla = -1;
            this.tipo_Factura = "";
            this.numero_Factura = -1;
            this.fecha_Entrega = DateTime.Today;
            this.precio_Venta = 0;
            this.cantidad = 0;
            this.subtotal = 0;
        }

        public int Id_Semilla { get => id_Semilla; set => id_Semilla = value; }
        public string Tipo_Factura { get => tipo_Factura; set => tipo_Factura = value; }
        public int Numero_Factura { get => numero_Factura; set => numero_Factura = value; }
        public DateTime Fecha_Entrega { get => fecha_Entrega; set => fecha_Entrega = value; }
        public double Precio_Venta { get => precio_Venta; set => precio_Venta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
    }
}
