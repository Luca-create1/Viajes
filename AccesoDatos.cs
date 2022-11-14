using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Viajes
{
    class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        string cadenaConexion;

        public AccesoDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            cadenaConexion = (@"Data Source=.\SQLEXPRESS;Initial Catalog=AgenciaViaje;Integrated Security=True");
        }


        private void conectar()
        {
           
            comando.Connection = conexion;
           
            comando.CommandType = CommandType.Text;
            conexion.Open();
        }

        public void desconectar()
        {
            conexion.Close();

        }

        public DataTable consultarBD(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            desconectar();

            return tabla;

        }
    }
}

