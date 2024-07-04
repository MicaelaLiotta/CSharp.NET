using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Text.Json;

namespace Formulario2doParcial
{

    public partial class MenuForm : Form
    {
        public List<Ingresante> ingresantes = new List<Ingresante>();

        public MenuForm()
        {
            InitializeComponent();
            IsMdiContainer = true; // Establecer como formulario contenedor
        }

        private void NuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            registroForm.MdiParent = this;
            registroForm.Show();
        }

        private void MenuForm_Load_1(object sender, EventArgs e)
        {

        }

        //Modificar/Eliminar Registro
        private void modificarEliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modificar/Eliminar Registro no realiza ninguna accion.");
        }

        //Serializar xml C++
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerializarXml("C++");
        }

        //Serializar xml C#
        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SerializarXml("C#");
        }

        //Serializar xml JavaScript
        private void javaScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerializarXml("JavaScript");
        }

        //Serializar json C++
        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SerializarJson("C++");
        }

        //Serializar json C#
        private void cToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SerializarJson("C#");
        }

        //Serializar json JavaScript
        private void javaScriptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SerializarJson("JavaScript");
        }

        private void SerializarXml(string nombreCurso)
        {
            List<Ingresante> ingresantesCurso = ingresantes.Where(i => i.Cursos.Contains(nombreCurso)).ToList();   //filtra los ingresantes con respectivo curso

            if (ingresantesCurso.Count > 0)
            {
                XmlSerializer miXml = new XmlSerializer(typeof(List<Ingresante>));     //se crea instancia xml para serializar los objetos de ingresante
                string nombreArchivo = $"{nombreCurso}.xml";
                

                try
                {

                    using (TextWriter writer = new StreamWriter(nombreArchivo))       //TextWriter para escribir en el archivo especificado
                    {
                        miXml.Serialize(writer, ingresantesCurso);               //serializa la lista ingresante
                    }

                    MessageBox.Show($"Serialización XML completada para el curso {nombreCurso}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al guardar el archivo XML para el curso {nombreCurso}: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"No hay ingresantes registrados en el curso {nombreCurso}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SerializarJson(string nombreCurso)
        {
            List<Ingresante> ingresantesCurso = ingresantes.Where(i => i.Cursos.Contains(nombreCurso)).ToList();

            if (ingresantesCurso.Count > 0)
            {
                string nombreArchivo = $"{nombreCurso}.json";
                string miJson = JsonSerializer.Serialize(ingresantesCurso);    //se crea instancia json para serializar los objetos de ingresante

                try
                {
                    File.WriteAllText(nombreArchivo, miJson);       //escribe sobre el archivo
                    MessageBox.Show($"Serialización JSON completada para el curso {nombreCurso}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo JSON para el curso {nombreCurso}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"No hay ingresantes registrados en el curso {nombreCurso}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ActualizarIngresantes(List<Ingresante> nuevosIngresantes)
        {
            ingresantes.Clear();
            ingresantes.AddRange(nuevosIngresantes);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}