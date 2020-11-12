using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.Entities
{
    class Semilla
    {
        private int id_semilla;
        private string nombre;
        private double stock_minimo;
        private double stock;
        private double precio_x_tonelada;
        private string descripcion;
        private string habilitado;
        private int borrado;

        public Semilla(int id_semilla, string nombre, double stock_minimo, double stock, double precio_x_tonelada, string descripcion, string habilitado, int borrado)
        {
            this.Id_semilla = id_semilla;
            this.Nombre = nombre;
            this.Stock_minimo = stock_minimo;
            this.Stock = stock;
            this.Precio_x_tonelada = precio_x_tonelada;
            this.Descripcion = descripcion;
            this.Habilitado = habilitado;
            this.Borrado = borrado;
        }
        public Semilla()
        {
            this.Id_semilla = -1;
            this.Nombre = "";
            this.Stock_minimo = 0;
            this.Stock = 0;
            this.Precio_x_tonelada = 0;
            this.Descripcion = "";
            this.Habilitado = "si";
            this.Borrado = 0;
        }

        public int Id_semilla { get => id_semilla; set => id_semilla = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Stock_minimo { get => stock_minimo; set => stock_minimo = value; }
        public double Stock { get => stock; set => stock = value; }
        public double Precio_x_tonelada { get => precio_x_tonelada; set => precio_x_tonelada = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Habilitado { get => habilitado; set => habilitado = value; }
        public int Borrado { get => borrado; set => borrado = value; }
    }
}
