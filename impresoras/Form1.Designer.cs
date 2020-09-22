using System;
using System.Diagnostics;


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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.marca = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.labelIP = new System.Windows.Forms.Label();
            this.IPaddress = new System.Windows.Forms.MaskedTextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 70);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(428, 70);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(298, 33);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // marca
            // 
            this.marca.AutoSize = true;
            this.marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca.Location = new System.Drawing.Point(53, 40);
            this.marca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(67, 25);
            this.marca.TabIndex = 2;
            this.marca.Text = "Marca";
            // 
            // modelo
            // 
            this.modelo.AutoSize = true;
            this.modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo.Location = new System.Drawing.Point(423, 40);
            this.modelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(77, 25);
            this.modelo.TabIndex = 3;
            this.modelo.Text = "Modelo";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 273);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(668, 328);
            this.textBox1.TabIndex = 4;
            // 
            // buttonInstall
            // 
            this.buttonInstall.Location = new System.Drawing.Point(428, 131);
            this.buttonInstall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(147, 113);
            this.buttonInstall.TabIndex = 5;
            this.buttonInstall.Text = "Instalar";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(53, 142);
            this.labelIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(30, 25);
            this.labelIP.TabIndex = 6;
            this.labelIP.Text = "IP";
            // 
            // IPaddress
            // 
            this.IPaddress.Location = new System.Drawing.Point(91, 142);
            this.IPaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IPaddress.Name = "IPaddress";
            this.IPaddress.Size = new System.Drawing.Size(167, 30);
            this.IPaddress.TabIndex = 8;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(634, 149);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 44);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ubicacionToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // ubicacionToolStripMenuItem
            // 
            this.ubicacionToolStripMenuItem.Name = "ubicacionToolStripMenuItem";
            this.ubicacionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ubicacionToolStripMenuItem.Text = "Ubicacion";
            this.ubicacionToolStripMenuItem.Click += new System.EventHandler(this.ubicacionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 645);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.IPaddress);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label marca;
        private System.Windows.Forms.Label modelo;
        private EventLog eventLog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.MaskedTextBox IPaddress;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ubicacionToolStripMenuItem;
    }
}

