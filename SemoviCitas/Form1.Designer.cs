
namespace SemoviCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.Generar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.buttonFecha = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasGeneradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodasLasCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora";
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Items.AddRange(new object[] {
            "LICENCIAS",
            "TENENCIA",
            "EMPLACAMIENTO",
            "CONCESIONES ",
            "ALTA/BAJA DE VEHICULOS"});
            this.comboBoxDepartamento.Location = new System.Drawing.Point(197, 161);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartamento.TabIndex = 4;
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00"});
            this.comboBoxHora.Location = new System.Drawing.Point(197, 282);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHora.TabIndex = 5;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(170, 227);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(148, 20);
            this.textBoxCorreo.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(170, 103);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(148, 20);
            this.textBoxNombre.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(389, 103);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(520, 282);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(117, 20);
            this.textBoxFecha.TabIndex = 9;
            // 
            // Generar
            // 
            this.Generar.BackColor = System.Drawing.Color.PaleGreen;
            this.Generar.Location = new System.Drawing.Point(197, 331);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(145, 51);
            this.Generar.TabIndex = 10;
            this.Generar.Text = "Generar cita";
            this.Generar.UseVisualStyleBackColor = false;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancelar.Location = new System.Drawing.Point(406, 331);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(145, 50);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // buttonFecha
            // 
            this.buttonFecha.Location = new System.Drawing.Point(389, 282);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(114, 21);
            this.buttonFecha.TabIndex = 12;
            this.buttonFecha.Text = "Seleccionar fecha";
            this.buttonFecha.UseVisualStyleBackColor = true;
            this.buttonFecha.Click += new System.EventHandler(this.buttonFecha_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasGeneradasToolStripMenuItem,
            this.mostrarTodasLasCitasToolStripMenuItem,
            this.cancelarCitaToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // citasGeneradasToolStripMenuItem
            // 
            this.citasGeneradasToolStripMenuItem.Name = "citasGeneradasToolStripMenuItem";
            this.citasGeneradasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.citasGeneradasToolStripMenuItem.Text = "citas Generadas";
            this.citasGeneradasToolStripMenuItem.Click += new System.EventHandler(this.citasGeneradasToolStripMenuItem_Click_1);
            // 
            // mostrarTodasLasCitasToolStripMenuItem
            // 
            this.mostrarTodasLasCitasToolStripMenuItem.Name = "mostrarTodasLasCitasToolStripMenuItem";
            this.mostrarTodasLasCitasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.mostrarTodasLasCitasToolStripMenuItem.Text = "Mostrar todas las citas";
            this.mostrarTodasLasCitasToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodasLasCitasToolStripMenuItem_Click);
            // 
            // cancelarCitaToolStripMenuItem
            // 
            this.cancelarCitaToolStripMenuItem.Name = "cancelarCitaToolStripMenuItem";
            this.cancelarCitaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cancelarCitaToolStripMenuItem.Text = "Cancelar cita";
            this.cancelarCitaToolStripMenuItem.Click += new System.EventHandler(this.cancelarCitaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SemoviCitas.Properties.Resources.NOMBRECITAS22;
            this.pictureBox1.Location = new System.Drawing.Point(176, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SemoviCitas.Properties.Resources.semovi_nota3;
            this.pictureBox2.Location = new System.Drawing.Point(257, 403);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 510);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFecha);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.comboBoxHora);
            this.Controls.Add(this.comboBoxDepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SemoviCitas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button buttonFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasGeneradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodasLasCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarCitaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

