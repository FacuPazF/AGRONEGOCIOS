using System;

namespace ProyectoAgronegocios.Entities
{
    class Empleado
    {
        private int cod_Empleado;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private DateTime fecha_Alta;
        private int cod_barrio;
        private string calle;
        private string numero_casa;
        private DateTime fecha_nacimiento;
        private int tipo_Empleado;
        private string contraseña;
        private string usuario;
        private int borrado;

        public Empleado(int cod_Empleado, string nombre, string apellido, string email, string telefono, DateTime fecha_Alta, int cod_barrio, string calle, string numero_casa, DateTime fecha_nacimiento, int tipo_Empleado, string contraseña, string usuario, int borrado)
        {
            this.cod_Empleado = cod_Empleado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.fecha_Alta = fecha_Alta;
            this.cod_barrio = cod_barrio;
            this.calle = calle;
            this.numero_casa = numero_casa;
            this.fecha_nacimiento = fecha_nacimiento;
            this.tipo_Empleado = tipo_Empleado;
            this.contraseña = contraseña;
            this.usuario = usuario;
            this.borrado = borrado;
        }

        public Empleado()
        {
            this.cod_Empleado = -1;
            this.nombre = "";
            this.apellido = "";
            this.email = "";
            this.telefono = "";
            this.fecha_Alta = DateTime.Now;
            this.cod_barrio = -1;
            this.calle = "";
            this.numero_casa = "";
            this.fecha_nacimiento = DateTime.Now;
            this.Tipo_Empleado = -1;
            this.borrado = 0;
        }

        public int Cod_Empleado { get => cod_Empleado; set => cod_Empleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime Fecha_Alta { get => fecha_Alta; set => fecha_Alta = value; }
        public int Cod_barrio { get => cod_barrio; set => cod_barrio = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Numero_casa { get => numero_casa; set => numero_casa = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public int Tipo_Empleado { get => tipo_Empleado; set => tipo_Empleado = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public int Borrado { get => borrado; set => borrado = value; }
    }
}
