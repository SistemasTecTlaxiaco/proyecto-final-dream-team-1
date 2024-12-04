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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string modificar = "DELETE FROM citas WHERE id_c=@id_c";
            MySqlCommand ins = new MySqlCommand(modificar, conexion.conectarabd());
            ins.Parameters.AddWithValue("@id_c", textBoxId.Text);            
            ins.ExecuteNonQuery();
            MessageBox.Show("\nCITA CANCELADA\n");
            textBoxId.Clear();           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mostrar();
        }
    }
}
