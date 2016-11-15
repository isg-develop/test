/*
 * Creado por SharpDevelop.
 * Usuario: elite
 * Fecha: 15/11/2016
 * Hora: 12:44 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Demos.Models
{
	/// <summary>
	/// Description of Docente.
	/// </summary>
	public class Docente
	{
		private String nombre, apellido, tipo;
        private  int horas;
        
		public Docente(String nombre, String apellido, String tipo, int horas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo = tipo;
            this.horas = horas;
        }
		

        public String getNombre(){
            return nombre;
        }
        public String getApellido() { 
            return apellido; 
        }
        public String getTipo() { 
            return tipo; 
        }
        public int getHoras() { 
            return horas; 
        }
        public void setHoras(int horas) {
            this.horas = horas;
        }
        public void setNombre(String nombre) { 
            this.nombre = nombre; 
        }
        public void setApellido(String apellido) { 
            this.apellido = apellido; 
        }
        public void setTipo(String tipo) { 
            this.tipo = tipo;
        }
        
        public String getNombreCompleto()
        {
            return nombre + "" + apellido;
        }
        public double getSueldoBruto()
        {
            if (tipo.Equals("android"))
                return 3 * horas;
            else if (tipo.Equals("web"))
                return 4 * horas;
            else if (tipo.Equals("desktop"))
                return 3.5 * horas;
            else
                return 5 * horas;

        }
        public double getDescuento()
        {
            return 0.10 * getSueldoBruto();
        }

        public double getNeto()
        {
            return getSueldoBruto() - getDescuento();
        }
        
        public void Mensaje(String undato){
	        string frase;
	 
	        frase = "Hola, como estas?";
	        Console.WriteLine("La frase es \"{0}\"", frase);
	 
	        Console.WriteLine("Introduce una nueva frase");
	        frase = Console.ReadLine();
	        Console.WriteLine("Ahora la frase es \"{0}\"", frase);
	 
	        if (frase == "Hola!"){
	            Console.WriteLine("Hola a ti también! ");
	        } else {
	        	Console.WriteLine("Hola a ti " + undato);
	        }
        }
	}
}
