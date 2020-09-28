using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.Entities
{
    class FormaPagoXfactura
    {
        private int id_Forma_Pago;
        private string tipo_Factura;
        private int numero_Factura;
        private double monto;
        private int dias_de_Plazo;

        public FormaPagoXfactura(int id_Forma_Pago, string tipo_Factura, int numero_Factura, double monto, int dias_de_Plazo)
        {
            this.Id_Forma_Pago = id_Forma_Pago;
            this.Tipo_Factura = tipo_Factura;
            this.Numero_Factura = numero_Factura;
            this.Monto = monto;
            this.Dias_de_Plazo = dias_de_Plazo;
        }
        public FormaPagoXfactura()
        {
            this.Id_Forma_Pago = -1;
            this.Tipo_Factura = "";
            this.Numero_Factura = -1;
            this.Monto = 0;
            this.Dias_de_Plazo = 0;
        }

        public int Id_Forma_Pago { get => id_Forma_Pago; set => id_Forma_Pago = value; }
        public string Tipo_Factura { get => tipo_Factura; set => tipo_Factura = value; }
        public int Numero_Factura { get => numero_Factura; set => numero_Factura = value; }
        public double Monto { get => monto; set => monto = value; }
        public int Dias_de_Plazo { get => dias_de_Plazo; set => dias_de_Plazo = value; }
    }
}
