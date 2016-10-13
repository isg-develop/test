using System;
using System.Data;
using System.Data.OleDb;

namespace SQLTester
{
    public class TestConnection_Access
    {
        public static void TestConnection(){
            Console.WriteLine("Iniciando...");
            //declaramos las variables         
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string archivo ="C:/base.mdb";
            string nombre_tabla ="tabla1";
            //------para archivos de 97-2003 usar la siguiente cadena
            string cadenaConexionArchivo = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';";
            //Creamos la conexion
            using (OleDbConnection conexion = new OleDbConnection(cadenaConexionArchivo))
            {
                try
                {
                    conexion.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    string consulta = "SELECT * From " + nombre_tabla;
                    dataAdapter = new OleDbDataAdapter(consulta, conexion); //traemos los datos en Adapter
                    dataSet = new DataSet(); // creamos la consulta del objeto DataSet
                    dataAdapter.Fill(dataSet, nombre_tabla);//llenamos el dataset
                    conexion.Close();//cerramos la conexion
                    Console.WriteLine("Conectado.");
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                     Console.WriteLine("Error, Verificar el archivo o el nombre de la tabla", ex.Message);
                }
            }
            
        }

        
    }
}
