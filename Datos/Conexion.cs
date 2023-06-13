using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos_Proyecto
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string clave;
        private bool seguridad;
        private static Conexion con = null;


        private Conexion()
        {
            this.Base = "BD_Proyecto_Minimarket";
            this.Servidor = "DESKTOP-RGP352F";
            this.Usuario = "sistema";
            this.clave = "12345678";
            this.seguridad = false;
        }

        public SqlConnection crearconexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = ($"Server={Servidor};Database={Base};User Id={Usuario};Password={clave};");
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }

    }
}
