using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO; 

namespace Formulario2doParcial
{
    public static class Funciones
    {
        private static int CalcularDigitoCuit(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };   //Cada posición del CUIT tiene asignado un multiplicador fijo según las normativas del sistema de identificación tributaria argentino
            char[] nums = cuit.ToCharArray();                      //Convertir el string del CUIT en un array de caracteres
            int total = 0;

            for (int i = 0; i < mult.Length; i++)                   //Iterar sobre cada posición del CUIT y calcular el producto      
            {
                total += int.Parse(nums[i].ToString()) * mult[i];    //Multiplicar cada dígito del CUIT por el multiplicador correspondiente
            }

            var resto = total % 11;                   // Calcular el resto de la división total por 11
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;        // Determinar el dígito verificador
        }

        public static bool ValidaCuit(string cuit)
        {
            try
            {

                if (string.IsNullOrEmpty(cuit))
                {
                    throw new ArgumentNullException(nameof(cuit), "El CUIT no puede ser nulo o vacío.");
                }
                //Quito los guiones, el cuit resultante debe tener 11 caracteres.
                cuit = cuit.Replace("-", string.Empty);
                if (cuit.Length != 11)
                {
                    throw new ArgumentException("El CUIT debe tener 11 caracteres.");
                }
                else
                {
                    int calculado = CalcularDigitoCuit(cuit);      // Calcular el dígito verificador esperado
                    int digito = int.Parse(cuit.Substring(10));    //Obtener el dígito verificador actual del CUIT
                    return calculado == digito;
                }
            }
            catch (ArgumentNullException ex)      //excepción si cadena es nula o vacia
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (ArgumentException ex)         //excepción si no tiene 11 caracteres
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado durante la validación del CUIT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    

        public static void mError(Form actual, string mensaje)         //MENSAJE DE ERROR
        {
            MessageBox.Show(actual, mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void mOk(Form actual, string mensaje)
        {
            MessageBox.Show(actual, mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool mConsulta(Form actual, string mensaje)     //SI O NO PARA VALIDAR DATOS
        {

            if (MessageBox.Show(actual, mensaje, "VALIDACION DATOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void mAdvertencia(Form actual, string mensaje)      //MENSAJE ADVERTENCIA
        {
            MessageBox.Show(actual, mensaje, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }



        public static void GuardarBaseDatos(string curso, Ingresante ingresante)
        {

          try
            {

                // Leer la cadena de conexión del archivo App.config
                string connectionString = ConfigurationManager.ConnectionStrings["ConexionBaseDatos"].ConnectionString;

               

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Ingresantes (Nombre, Direccion, Edad, CUIT, Genero, Pais, Curso) " +
                                   "VALUES (@Nombre, @Direccion, @Edad, @CUIT, @Genero, @Pais, @Curso)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", ingresante.Nombre);
                        command.Parameters.AddWithValue("@Direccion", ingresante.Direccion);
                        command.Parameters.AddWithValue("@Edad", ingresante.Edad);
                        command.Parameters.AddWithValue("@CUIT", ingresante.Cuit);
                        command.Parameters.AddWithValue("@Genero", ingresante.Genero);
                        command.Parameters.AddWithValue("@Pais", ingresante.Pais);
                        command.Parameters.AddWithValue("@Curso", curso);


                        command.ExecuteNonQuery();                        //se ejecuta la consulta insertando los datos en la base de datos
                    }
                }

                MessageBox.Show($"Datos guardado en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)       //error sql
            {
                MessageBox.Show($"Error al guardar los datos en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)          //otros errores
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

