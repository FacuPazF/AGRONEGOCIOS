using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.Entities
{
    class Cliente
    {
        private int id_Cliente_Proveedor;
        private string nombre;
        private string apellido;
        private string razon_Social;
        private string email;
        private string telefono;
        private int cod_Barrio;
        private int id_Tipo;
        private string cuil_cuit;
        private int borrado;

        public Cliente(int id_Cliente_Proveedor, string nombre, string apellido, string razon_Social, string email, string telefono, int cod_Barrio, int id_Tipo, string cuil_cuit, int borrado)
        {
            this.Id_Cliente_Proveedor = id_Cliente_Proveedor;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Razon_Social = razon_Social;
            this.Email = email;
            this.Telefono = telefono;
            this.Cod_Barrio = cod_Barrio;
            this.Id_Tipo = id_Tipo;
            this.Cuil_cuit = cuil_cuit;
            this.Borrado = borrado;
        }
        public Cliente()
        {
            this.Id_Cliente_Proveedor = -1;
            this.Nombre = "";
            this.Apellido = "";
            this.Razon_Social = "";
            this.Email = "";
            this.Telefono = "";
            this.Cod_Barrio = -1;
            this.Id_Tipo = -1;
            this.Cuil_cuit = "";
            this.Borrado = 0;
        }

        public int Id_Cliente_Proveedor { get => id_Cliente_Proveedor; set => id_Cliente_Proveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Razon_Social { get => razon_Social; set => razon_Social = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Cod_Barrio { get => cod_Barrio; set => cod_Barrio = value; }
        public int Id_Tipo { get => id_Tipo; set => id_Tipo = value; }
        public string Cuil_cuit { get => cuil_cuit; set => cuil_cuit = value; }
        public int Borrado { get => borrado; set => borrado = value; }
    }
}
