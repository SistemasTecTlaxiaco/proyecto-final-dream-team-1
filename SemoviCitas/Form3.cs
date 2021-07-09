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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.conectarabd();                
                dataGridView1.DataSource = mostrar();

            }
            catch
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BASE DE DATOS2");
            }
        }

        public DataTable mostrar()
        {
            conexion.conectarabd();

            DataTable ListaCita = new DataTable();
            string listar = "SELECT * FROM citas ";
            MySqlCommand instancia = new MySqlCommand(listar, conexion.conectarabd());
            MySqlDataAdapter actualiza = new MySqlDataAdapter(instancia);
            actualiza.Fill(ListaCita);
            return ListaCita;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mostrar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxNombre.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxDepartamento.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxCorreo.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxFecha.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBoxHora.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string modificar = "UPDATE citas SET nombre=@nombre,departamento=@departamento,correo=@correo,fecha=@fecha,hora=@hora WHERE id_c=@id_c";
            MySqlCommand ins = new MySqlCommand(modificar, conexion.conectarabd());
            ins.Parameters.AddWithValue("@id_c", textBoxId.Text);
            ins.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
            ins.Parameters.AddWithValue("@departamento", comboBoxDepartamento.Text);
            ins.Parameters.AddWithValue("@correo", textBoxCorreo.Text);
            ins.Parameters.AddWithValue("@fecha", textBoxFecha.Text);
            ins.Parameters.AddWithValue("@hora", comboBoxHora.Text);
            ins.ExecuteNonQuery();

            MessageBox.Show("\nCAMBIO GENERADO\n" + "Nombre: " + textBoxNombre.Text +
                          "\nDepartamento: " + comboBoxDepartamento.SelectedItem +
                           "\nCorreo: " + textBoxCorreo.Text +
                           "\nHora: " +  comboBoxHora.Text +
                           "\nFecha: " + monthCalendar1.SelectionStart.Day.ToString() + "/" +
                                         monthCalendar1.SelectionStart.Month.ToString() + "/" +
                                         monthCalendar1.SelectionStart.Year.ToString());

            dataGridView1.DataSource = mostrar();

            textBoxId.Clear();
            textBoxNombre.Clear();
            comboBoxDepartamento.ResetText();
            textBoxCorreo.Clear();
            textBoxFecha.Clear();
            comboBoxHora.ResetText();
        }

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            textBoxFecha.Text = monthCalendar1.SelectionStart.Year.ToString() + "-" +
                                 monthCalendar1.SelectionStart.Month.ToString() + "-" +
                                monthCalendar1.SelectionStart.Day.ToString();
        }
    }
}
