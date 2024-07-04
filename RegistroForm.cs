using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;


namespace Formulario2doParcial
{
    public partial class RegistroForm : Form
    {
        private List<string> cursos;
        private static List<Ingresante> ingresantes = new List<Ingresante>();
        private readonly string ruta;

        public RegistroForm()
        {
            InitializeComponent();
            cursos = new List<string>();

        }

        private void btoIngresar_Click(object sender, EventArgs e)
        {
            // obtenemos los valores
            string nombre = txtNombre.Text.Trim();// Metodo TRIM para eliminar espacios al principio y final
            string direccion = txtDireccion.Text.Trim();
            int edad = (int)nupEdad.Value;
            string cuit = mtbCUIT.Text.Trim();
            string genero = "";
            if (rbFemenino.Checked) genero = rbFemenino.Text.Trim();
            if (rbMasculino.Checked) genero = rbMasculino.Text.Trim();
            if (rbNoBinario.Checked) genero = rbNoBinario.Text.Trim();

            string pais = lbPais.Text.Trim();// Obtenci�n del pa�s seleccionado. 

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre.");
                return;
            }

            if (string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Ingrese la direcci�n.");
                return;
            }

            if (edad < 18 || edad > 100) // Asegurarse de que la edad est� dentro de un rango razonable
            {
                MessageBox.Show("Ingrese una edad v�lida (entre 18 y 100).");
                return;
            }

            if (string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Seleccione un g�nero.");
                return;
            }

                cursos.Clear();
            if (chkCsharp.Checked) cursos.Add(chkCsharp.Text.Trim());
            if (chkCmas.Checked) cursos.Add(chkCmas.Text.Trim());
            if (chkJavaScript.Checked) cursos.Add(chkJavaScript.Text.Trim());


            if (cursos.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un curso.");
                return;
            }

            if (string.IsNullOrEmpty(pais))
            {
                MessageBox.Show("Seleccione un pa�s.");
                return;
            }

            if (!Funciones.ValidaCuit(cuit))
            {
                MessageBox.Show("Ingrese un CUIT v�lido.");
                return;
            }

            Ingresante ing = new Ingresante
            {
                Nombre = nombre,
                Direccion = direccion,
                Edad = edad,
                Cuit = cuit,
                Genero = genero,
                Pais = pais,
                Cursos = cursos.ToArray() // Se hace una copia de la lista de cursos
            };


            // Agregamos el ingresante a la lista
            ingresantes.Add(ing);

            if (Funciones.mConsulta(this, "Datos Ingresante \n" + "Nombre: " + ing.Nombre + "\nDireccion: " + ing.Direccion + "\nEdad: " + ing.Edad + "\nCUIT: " + ing.Cuit + "\nGenero: " + ing.Genero))
            {
                if (MessageBox.Show(ing.ToStringCursos(), "Cursos Inscripto", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (var curso in cursos)
                    {
                        GuardarDatosDeIngresante(curso, ing); //Se guarda txt
                       
                    }
                    Vaciar();
                }
                else
                {
                    MessageBox.Show("Verifique los datos e intente nuevamente");
                }
            }
            else
            {
                MessageBox.Show("Datos Descartados");
                Vaciar();
            }

        }

        private void GuardarDatosDeIngresante(string curso, Ingresante ingresante)
        {
            string ubicacion = Directory.GetCurrentDirectory(); // Se obtiene la direcci�n actual del proyecto
            string ruta = Path.Combine(ubicacion, $"{curso}.txt"); // Establezco el nombre del archivo y la ubicaci�n del mismo

            try
            {
                // Verificar si ya hay 40 l�neas en el txt y si es as� no guarda
                if (File.Exists(ruta) && File.ReadAllLines(ruta).Length >= 40)
                {
                    throw new InvalidOperationException($"El curso {curso} ya tiene 40 inscriptos.");
                }

                // Verificar si el CUIT ya existe
                if (File.Exists(ruta) && File.ReadAllLines(ruta).Any(linea => linea.Contains(ingresante.Cuit)))
                {
                    throw new InvalidOperationException($"El CUIT {ingresante.Cuit} ya est� registrado en el curso {curso}.");
                }

                // Escribir el contenido en el archivo usando StreamWriter en modo de ap�ndice
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    string datosIngresante = $"{ingresante.Mostrar()}|{curso}";
                    sw.WriteLine(datosIngresante);
                }

                Funciones.GuardarBaseDatos(curso, ingresante); // Llamada al m�todo que guarda en la base de datos

                MessageBox.Show($"Datos guardados en el curso {curso}", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar la lista de ingresantes en el formulario MenuForm
                MenuForm menuForm = Application.OpenForms.OfType<MenuForm>().FirstOrDefault();
                menuForm?.ActualizarIngresantes(ingresantes); // Actualizar la lista de ingresantes en el formulario MenuForm
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos del ingresante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }



        internal void Vaciar()
        {
            txtDireccion.Text = "";
            txtNombre.Text = "";
            nupEdad.Value = 18;
            mtbCUIT.Text = "";
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbNoBinario.Checked = false;
            chkCsharp.Checked = false;
            chkCmas.Checked = false;
            chkJavaScript.Checked = false;
            lbPais.ClearSelected();
        }

        
        private void lbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {

        }

        private void gbDetalleUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void gbGenero_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
