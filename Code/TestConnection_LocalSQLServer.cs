using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLTester
{
    class TestConnection_LocalSQLServer
    {
        public static void TestConnection()
        {
            Console.WriteLine("Iniciando...");
            //declaramos las variables         
            DataSet dataSet = null;
            SqlDataAdapter dataAdapter = null;
            String connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\...\DBSQLserver\dase1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "SELECT * From Tabla1";
                    dataAdapter = new SqlDataAdapter(consulta, connection); //traemos los datos en Adapter
                    dataSet = new DataSet(); // creamos la consulta del objeto DataSet
                    dataAdapter.Fill(dataSet, "tabla1");//llenamos el dataset
                    connection.Close();//cerramos la conexion
                    Console.WriteLine("Conectado.");
                }
                catch (SqlException)
                {
                    Console.WriteLine("Error en la conexión.");
                }
            } 
        }
    }
}
