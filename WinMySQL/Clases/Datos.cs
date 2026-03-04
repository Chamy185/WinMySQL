using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySqlConnector;

namespace WinMySQL.Clases
{
    internal class Datos
    {
        String cadenaConexion = "server=localhost;user=luis;pwd=joseluis; Database=escolar";
        MySqlConnection conexion;

        private void conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        private void Desconectar()
        {
            try
            {
                if(conexion != null)
                {
                    conexion.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public DataSet ejecutar(String Comando)
        {
            try
            {
               conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(Comando, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch(MySqlException ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
       
        public bool ejecutarComando(String Comando)
        {
            try
            {
               conectar();
                MySqlCommand cmd = new MySqlCommand(Comando, conexion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }


        }
    }
}
