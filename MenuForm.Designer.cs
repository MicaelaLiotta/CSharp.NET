using Formulario2doParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Formulario2doParcial
{
    partial class MenuForm
    {
        // Aquí se mantiene el código generado por el diseñador
        private IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private ToolStripMenuItem modificarEliminarRegistroToolStripMenuItem;
        private ToolStripMenuItem exportacionesToolStripMenuItem;
        private ToolStripMenuItem exportacionesToolStripMenuItem1;
        private ToolStripMenuItem serializaciónXMLToolStripMenuItem1;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem javaScriptToolStripMenuItem;
        private ToolStripMenuItem serializaciónJsonToolStripMenuItem1;
        private ToolStripMenuItem cToolStripMenuItem2;
        private ToolStripMenuItem cToolStripMenuItem3;
        private ToolStripMenuItem javaScriptToolStripMenuItem1;
        private ToolStripMenuItem serializaciónXMLToolStripMenuItem;
        private ToolStripMenuItem serializaciónJsonToolStripMenuItem;

        // Método generado por el diseñador para inicializar componentes
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            nuevoRegistroToolStripMenuItem = new ToolStripMenuItem();
            modificarEliminarRegistroToolStripMenuItem = new ToolStripMenuItem();
            exportacionesToolStripMenuItem = new ToolStripMenuItem();
            exportacionesToolStripMenuItem1 = new ToolStripMenuItem();
            serializaciónXMLToolStripMenuItem1 = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem1 = new ToolStripMenuItem();
            javaScriptToolStripMenuItem = new ToolStripMenuItem();
            serializaciónJsonToolStripMenuItem1 = new ToolStripMenuItem();
            cToolStripMenuItem2 = new ToolStripMenuItem();
            cToolStripMenuItem3 = new ToolStripMenuItem();
            javaScriptToolStripMenuItem1 = new ToolStripMenuItem();
            serializaciónXMLToolStripMenuItem = new ToolStripMenuItem();
            serializaciónJsonToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, exportacionesToolStripMenuItem, exportacionesToolStripMenuItem1 });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(524, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoRegistroToolStripMenuItem, modificarEliminarRegistroToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            nuevoRegistroToolStripMenuItem.Size = new Size(219, 22);
            nuevoRegistroToolStripMenuItem.Text = "Nuevo Registro";
            nuevoRegistroToolStripMenuItem.Click += NuevoRegistroToolStripMenuItem_Click;
            // 
            // modificarEliminarRegistroToolStripMenuItem
            // 
            modificarEliminarRegistroToolStripMenuItem.Name = "modificarEliminarRegistroToolStripMenuItem";
            modificarEliminarRegistroToolStripMenuItem.Size = new Size(219, 22);
            modificarEliminarRegistroToolStripMenuItem.Text = "Modificar/Eliminar Registro";
            modificarEliminarRegistroToolStripMenuItem.Click += modificarEliminarRegistroToolStripMenuItem_Click;
            // 
            // exportacionesToolStripMenuItem
            // 
            exportacionesToolStripMenuItem.Name = "exportacionesToolStripMenuItem";
            exportacionesToolStripMenuItem.Size = new Size(12, 20);
            // 
            // exportacionesToolStripMenuItem1
            // 
            exportacionesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { serializaciónXMLToolStripMenuItem1, serializaciónJsonToolStripMenuItem1 });
            exportacionesToolStripMenuItem1.Name = "exportacionesToolStripMenuItem1";
            exportacionesToolStripMenuItem1.Size = new Size(93, 20);
            exportacionesToolStripMenuItem1.Text = "Exportaciones";
            // 
            // serializaciónXMLToolStripMenuItem1
            // 
            serializaciónXMLToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cToolStripMenuItem, cToolStripMenuItem1, javaScriptToolStripMenuItem });
            serializaciónXMLToolStripMenuItem1.Name = "serializaciónXMLToolStripMenuItem1";
            serializaciónXMLToolStripMenuItem1.Size = new Size(166, 22);
            serializaciónXMLToolStripMenuItem1.Text = "Serialización XML";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(126, 22);
            cToolStripMenuItem.Text = "C++";
            cToolStripMenuItem.Click += cToolStripMenuItem_Click;
            // 
            // cToolStripMenuItem1
            // 
            cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            cToolStripMenuItem1.Size = new Size(126, 22);
            cToolStripMenuItem1.Text = "C#";
            cToolStripMenuItem1.Click += cToolStripMenuItem1_Click;
            // 
            // javaScriptToolStripMenuItem
            // 
            javaScriptToolStripMenuItem.Name = "javaScriptToolStripMenuItem";
            javaScriptToolStripMenuItem.Size = new Size(126, 22);
            javaScriptToolStripMenuItem.Text = "JavaScript";
            javaScriptToolStripMenuItem.Click += javaScriptToolStripMenuItem_Click;
            // 
            // serializaciónJsonToolStripMenuItem1
            // 
            serializaciónJsonToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cToolStripMenuItem2, cToolStripMenuItem3, javaScriptToolStripMenuItem1 });
            serializaciónJsonToolStripMenuItem1.Name = "serializaciónJsonToolStripMenuItem1";
            serializaciónJsonToolStripMenuItem1.Size = new Size(166, 22);
            serializaciónJsonToolStripMenuItem1.Text = "Serialización Json";
            // 
            // cToolStripMenuItem2
            // 
            cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            cToolStripMenuItem2.Size = new Size(126, 22);
            cToolStripMenuItem2.Text = "C++";
            cToolStripMenuItem2.Click += cToolStripMenuItem2_Click;
            // 
            // cToolStripMenuItem3
            // 
            cToolStripMenuItem3.Name = "cToolStripMenuItem3";
            cToolStripMenuItem3.Size = new Size(126, 22);
            cToolStripMenuItem3.Text = "C#";
            cToolStripMenuItem3.Click += cToolStripMenuItem3_Click;
            // 
            // javaScriptToolStripMenuItem1
            // 
            javaScriptToolStripMenuItem1.Name = "javaScriptToolStripMenuItem1";
            javaScriptToolStripMenuItem1.Size = new Size(126, 22);
            javaScriptToolStripMenuItem1.Text = "JavaScript";
            javaScriptToolStripMenuItem1.Click += javaScriptToolStripMenuItem1_Click;
            // 
            // serializaciónXMLToolStripMenuItem
            // 
            serializaciónXMLToolStripMenuItem.Name = "serializaciónXMLToolStripMenuItem";
            serializaciónXMLToolStripMenuItem.Size = new Size(32, 19);
            // 
            // serializaciónJsonToolStripMenuItem
            // 
            serializaciónJsonToolStripMenuItem.Name = "serializaciónJsonToolStripMenuItem";
            serializaciónJsonToolStripMenuItem.Size = new Size(32, 19);
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 461);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
