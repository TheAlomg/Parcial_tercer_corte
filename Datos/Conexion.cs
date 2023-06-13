using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Conexion
    {
        private string Basededatos;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;


        private Conexion()
        {
            this.Basededatos = "bd_parcial";
            this.Servidor = "localhost";
            this.Puerto = "3306";
            this.Usuario = "user_ventas";
            this.Clave = "Alejandro23#";
        }


        public MySqlConnection crearconexcion()
        {
            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = ($"datasource={Servidor};Database={Basededatos};User Id={Usuario};Password={Clave};");
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }


        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
