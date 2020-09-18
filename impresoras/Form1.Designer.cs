using System;
using System.Diagnostics;
using System.IO;

namespace impresoras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.initilizeVariables();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.marca = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(this.marcas.getNameFolders());
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(286, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // marca
            // 
            this.marca.AutoSize = true;
            this.marca.Location = new System.Drawing.Point(39, 22);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(47, 17);
            this.marca.TabIndex = 2;
            this.marca.Text = "Marca";
            // 
            // modelo
            // 
            this.modelo.AutoSize = true;
            this.modelo.Location = new System.Drawing.Point(286, 22);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(54, 17);
            this.modelo.TabIndex = 3;
            this.modelo.Text = "Modelo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void initilizeVariables()
        {
            String marcasPath = Path.Combine(Directory.GetCurrentDirectory(), @"maquinas");
            this.marcas = new Printers(marcasPath);

            //String modeloPath = Path.Combine(marcasPath, this.comboBox1.Text);
            //this.modelos = new Printers(modeloPath);
        }

        #endregion
        private Printers marcas;
        private Printers modelos;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label marca;
        private System.Windows.Forms.Label modelo;
    }
}

