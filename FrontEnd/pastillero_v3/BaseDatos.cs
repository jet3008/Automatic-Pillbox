using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pastillero_v3
{
    class BaseDatos
    {
        private string cadenaConexion = "Data Source=DESKTOP-NGRSR1J; Initial Catalog=proyecto; Integrated Security=true;";

        public static string nombreCompleto = "";
        public static string tipoUsuario = "";

        public Boolean iniciarSesion(string nomus, string con)
        {
            nombreCompleto = "";
            tipoUsuario = "";

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            SqlParameter parnomus = new SqlParameter("@nomus", nomus);
            SqlParameter parcon = new SqlParameter("@con", con);

            SqlCommand comando = new SqlCommand("SELECT nombre, apellidoPaterno, apellidoMaterno, tipoUsuario FROM usuario WHERE nombreUsuario = @nomus AND contrasena COLLATE Latin1_General_CS_AS = @con", conexion);
            comando.Parameters.Add(parnomus);
            comando.Parameters.Add(parcon);

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                nombreCompleto = lector.GetString(0) + " " + lector.GetString(1) + " " + lector.GetString(2);
                tipoUsuario = lector.GetString(3);
            }

            lector.Close();
            conexion.Close();

            if (String.IsNullOrEmpty(tipoUsuario))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
