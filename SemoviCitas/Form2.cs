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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.conectarabd();  
            }
            catch
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BASE DE DATOS2");
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSelecDia.Text = monthCalendar1.SelectionStart.Year.ToString() + "-" +
                                 monthCalendar1.SelectionStart.Month.ToString() + "-" +
                                monthCalendar1.SelectionStart.Day.ToString();        
        }

        public DataTable mostrar(){
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
            string fecha = textBoxSelecDia.Text;
            string depto = comboBoxSelecDepartamento.Text;
            string horab = comboBox1.Text;
            MySqlDataReader reader = null;
            string buscar = "SELECT * FROM citas WHERE fecha ='" + fecha + "' AND  departamento = '" + depto + "' AND  hora = '" + horab + "'";
              try
            {
                MySqlCommand cmd4 = new MySqlCommand(buscar, conexion.conectarabd());
                reader = cmd4.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxSelecDia.Text = reader.GetString(4);
                        comboBoxSelecDepartamento.Text = reader.GetString(2);
                        textBox1.Text = reader.GetString(1);
                        textBox2.Text = reader.GetString(3);
                        comboBox1.Text = reader.GetString(5);                       
                    }
                }
                else
                {
                    reader.Read();
                    MessageBox.Show("No se encontro el registro");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("erro al buscar" + ex.Message);
            }
            finally
            {
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBoxSelecDia.Clear();
            textBox2.Clear();
            comboBoxSelecDepartamento.ResetText();
            comboBox1.ResetText();
        }
    }
}
