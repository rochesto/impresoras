using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace impresoras
{
    public partial class Form1 : Form
    {
        private Printers marcas;
        private String marcasPath = "";
        private Printers modelos;
        private String modelosPath = "";

        public Form1()
        {
            InitializeComponent();
            this.initilizeVariables();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void initilizeVariables()
        {
            this.marcasPath = Path.Combine(Directory.GetCurrentDirectory(), @"maquinas");
            this.marcas = new Printers(marcasPath);
            this.comboBox1.Items.AddRange(this.marcas.getNameFolders());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.modelosPath = Path.Combine(marcasPath, this.comboBox1.Text);
                this.modelos = new Printers(this.modelosPath);
                this.comboBox2.Items.AddRange(this.modelos.getNameFolders());
            }
            catch(Exception exc)
            {
                this.textBox1.AppendText(exc.Message);
            }
            
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {

        }
    }
}
