using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//libreria nueva
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {

        //se declara la ruta
        string ruta = "server=localhost;User Id=root;password=sa;database=bd_crjr703";

        public Form4()
        {
            InitializeComponent();

            try
            {
                MySqlConnection con = new MySqlConnection(ruta);
                con.Open();
                string consulta = "select * from pc_escritorio";
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);


                //lleno
                DataSet ds = new DataSet();
                da.Fill(ds, "pc_escritorio");

                //datos al datagriew
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show("Se produjo un error debido a : " + ee.ToString());

            }




        }

        //INSERTAR
        private void button1_Click(object sender, EventArgs e)
        {

        }


        //FUNCION ISNUMERIC
        private static bool IsNumeric(string value)
        {
            int number;
            return Int32.TryParse(value, out number);

        }

        //Marca
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (13))
            {
                if (!IsNumeric(textBox1.Text.Trim()))
                {
                    textBox2.Focus();
                }
                else
                {
                    MessageBox.Show("ingrese solo letras");
                    textBox1.Clear();
                }
            }
        }

        //modelo
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (13))
            {
                 textBox3.Focus();
               
            }
        }

        //cantidad de ram
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (13))
            {
                if (IsNumeric(textBox3.Text.Trim()))
                {
                    radioButton1.Focus();
                }
                else
                {
                    MessageBox.Show("ingrese solo letras");
                    textBox3.Clear();
                }
            }
        }

        //radiobutton Intel
        private void radioButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (13))
            {
                radioButton2.Focus();
            }
        }

        //radiobutton amd
        private void radioButton2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (13))
            {
                textBox4.Focus();
                radioButton2.Checked = false;
            }
        }

        //capacidad HDD
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (13))
            {
                if (IsNumeric(textBox4.Text.Trim()))
                {
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("ingrese solo letras");
                    textBox4.Clear();
                }
            }
        }

        //LIMPIAR   
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Focus();
        }
    }
}
