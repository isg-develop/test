using System;
using System.Data;
using System.Data.OleDb;

namespace SQLTester
{
    public class TestConnection_Excel
    {
        public static void TestConnection()
        {
            Console.WriteLine("Iniciando...");
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            String hoja = "Hoja1";
            String archivo = "C:/Libro1.xls";
            string consultaHojaExcel = "Select * from [" + hoja + "$]";
            string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            try
            {
                //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                conexion.Open(); //abrimos la conexion
                dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                conexion.Close();//cerramos la conexion    
                Console.WriteLine("Conectado.");
            }
            catch (Exception ex)
            {
                //en caso de haber una excepcion que nos mande un mensaje de error
                Console.WriteLine("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
            }
        }

    }
}
