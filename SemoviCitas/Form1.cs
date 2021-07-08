using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SemoviCitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.conectarabd();                            
            }
            catch
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BASE DE DATOS");
            }
        }

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            textBoxFecha.Text = monthCalendar1.SelectionStart.Year.ToString() + "-" +
                                monthCalendar1.SelectionStart.Month.ToString() + "-" +
                                monthCalendar1.SelectionStart.Day.ToString();
        }

        
        private void Generar_Click(object sender, EventArgs e)
        {
            string insertar = "INSERT INTO citas(nombre,departamento,correo,fecha,hora)values(@nombre,@departamento,@correo,@fecha,@hora)";
            MySqlCommand ins = new MySqlCommand(insertar, conexion.conectarabd());
            ins.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
            ins.Parameters.AddWithValue("@departamento", comboBoxDepartamento.Text);
            ins.Parameters.AddWithValue("@correo", textBoxCorreo.Text);
            ins.Parameters.AddWithValue("@fecha", textBoxFecha.Text);
            ins.Parameters.AddWithValue("@hora", comboBoxHora.Text);
            ins.ExecuteNonQuery();

            MessageBox.Show("Nombre: " + textBoxNombre.Text +
                           "\nDepartamento: " + comboBoxDepartamento.SelectedItem +
                            "\nCorreo: " + textBoxCorreo.Text +
                            "\nHora: " +  comboBoxHora.Text +
                            "\nFecha: " + monthCalendar1.SelectionStart.Day.ToString() + "/" +
                                          monthCalendar1.SelectionStart.Month.ToString() + "/" +
                                          monthCalendar1.SelectionStart.Year.ToString());

            textBoxNombre.Clear();
            comboBoxDepartamento.ResetText();
            textBoxCorreo.Clear();
            textBoxFecha.Clear();
            comboBoxHora.ResetText();

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            comboBoxDepartamento.ResetText();
            textBoxCorreo.Clear();
            textBoxFecha.Clear();
            comboBoxHora.ResetText();

        }

      
        private void citasGeneradasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formulario2 = new Form2();
            formulario2.Show();
        }

        private void mostrarTodasLasCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario3 = new Form3();
            formulario3.Show();
        }

        private void cancelarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario4 = new Form4();
            formulario4.Show();
        }

        
    }
}
