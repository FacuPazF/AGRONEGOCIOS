﻿using System.Data;
using System.Data.SqlClient;

namespace ProyectoAgronegocios.DataAccessLayer
{
    static class DBHelper
    {
        private static SqlConnection conexion = new SqlConnection();
        private static SqlCommand comando = new SqlCommand();
        private static string cadenaConexion = @"Data Source=DESKTOP-JAHJSOF\SQLEXPRESS;Initial Catalog=Agronegocios;Integrated Security=True";

        private static void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        private static void desconectar()
        {
            conexion.Close();
        }

        public static DataTable consultar(string cSQL)
        {
            DataTable tabla = new DataTable();
            
            conectar();
            comando.CommandText = cSQL;
            tabla.Load(comando.ExecuteReader());
            desconectar();

            return tabla;
        }
    }
}
