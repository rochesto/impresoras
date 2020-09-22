using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace impresoras
{
    public partial class ManageSettings : Form
    {
        public ManageSettings()
        {
            InitializeComponent();
            initializeVariables();
        }

        public void initializeVariables()
        {
            this.textBox1.Text = Properties.Settings.Default.ruta;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
