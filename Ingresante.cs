using System;
using System.Text;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Formulario2doParcial
{
    [Serializable]
    public class Ingresante
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Cuit { get; set; }
        public string Genero { get; set; }
        public string Pais { get; set; }

        
        public string[] Cursos { get; set;  } 

        public Ingresante(string nombre, string direccion, int edad, string cuit, string genero, string pais, string[] cursos)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Cuit = cuit;
            this.Genero = genero;
            this.Cursos = cursos ?? new string[0];
            this.Pais = pais;
        }

        public Ingresante()
        {
            this.Nombre = "";
            this.Direccion = "";
            this.Edad = 0;
            this.Cuit = "";
            this.Genero = "";
            this.Pais = "";
            this.Cursos = new string[0];
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Nombre}|{Direccion}|{Cuit}|{Genero}|{Pais}|{Edad}");
            return sb.ToString();
        }


        public override String ToString()        //devuelve la cadena del objeto
        {
            return Nombre + "\n" + "Dirección" + Direccion + "\n" + "edad: " + Edad + "\n" + " Cuit:" + Cuit + "\n" + "Genero :" + Genero + "\n" + Pais;
        }

        public String ToStringCursos()
        {
            return "Los cursos seleccionados son: \n" + string.Join("\n", Cursos);    //string.Join une los cursos y los devuelve con un salto de linea
        }

     
    }
}
