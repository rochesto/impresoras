using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace impresoras
{
    public partial class Form1 : Form
    {
        private Printers marcas;
        private String marcasPath = "";
        private Printers modelos;
        private String modelosPath = "";
        private String scriptPath = "";

        public Form1()
        {
            InitializeComponent();
            this.initilizeVariables();
        }

        private void initilizeVariables()
        {
            Properties.Settings.Default.Reload();
            try
            {
                this.marcasPath = Properties.Settings.Default.ruta;
                this.marcas = new Printers(marcasPath);
                this.comboBox1.Items.AddRange(this.marcas.getNameFolders());
                this.comboBox1.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                this.textBox1.Text = "Error al leer archivos de opciones";
                this.marcasPath = String.Concat(Directory.GetCurrentDirectory(), @"maquinas");
            }

            
            this.IPaddress.Mask = "000.000.000.000";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox2.Items.Clear();
            try
            {
                this.modelosPath = Path.Combine(this.marcasPath, this.comboBox1.Text);
                this.modelos = new Printers(this.modelosPath);
                this.comboBox2.Items.AddRange(this.modelos.getNameFolders());
                this.comboBox2.SelectedIndex = 0;
            }
            catch(Exception exc)
            {
                this.textBox1.AppendText(exc.Message);
            }
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            this.scriptPath = String.Concat(this.scriptPath, "\\install.bat"); 

            String command = String.Concat(this.scriptPath, " ", this.IPaddress.Text);
            this.textBox1.Text = this.scriptPath;

            this.textBox1.Text = Scripts.RunCmdAdmin(command);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.scriptPath = Path.Combine(this.modelosPath, this.comboBox2.Text);
        }

        private void buttonExit_Click(object sender, EventArgs e) => Close();

        private void ubicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSettings ms = new ManageSettings();
            ms.Show();
        }
    }
}
