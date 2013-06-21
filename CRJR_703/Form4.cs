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
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && radioButton1.Checked == true || radioButton2.Checked == true)
            {
                try
                {
                    //conexión llamada CON
                    MySqlConnection con = new MySqlConnection(ruta);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    string tp = "";

                    if (radioButton1.Checked == true)
                    {
                        tp = "intel";
                    }

                    if (radioButton2.Checked == true)
                    {
                        tp = "amd";


                    }

                    string consulta = "insert into pc_escritorio(marca,modelo,cant_ram,tipo_pro,capacidad) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+tp+"','"+textBox4.Text+"')";
                    cmd.Connection = con;
                    cmd.CommandText = consulta;
                    cmd.ExecuteNonQuery();

                    string consulta2 = "select * from pc_escritorio";
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta2, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "pc_escritorio");
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();



                }
                catch (Exception ee)
                {
                    MessageBox.Show("Se produjo un error debido a : " + ee.ToString());
                }
            }
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
                    MessageBox.Show("ingrese solo números");
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


        //Modificar
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && radioButton1.Checked == true || radioButton2.Checked == true)
            {
                try
                {

                    MySqlConnection con = new MySqlConnection(ruta);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    string tp = "";

                    if (radioButton1.Checked == true)
                    {
                        tp = "intel";
                    }

                    if (radioButton2.Checked == true)
                    {
                        tp = "amd";


                    }

                    string consulta = "update pc_escritorio set marca = '"+textBox1.Text+"', modelo '"+textBox2.Text+"', cant_ram ='"+textBox3.Text+"', tipo_pro = '"+tp+"', capacidad = '"+textBox4.Text+"' where cod_pc_e"


                }
                catch (Exception ee)
                {
                    MessageBox.Show("Se produjo un error debido a : " + ee.ToString());
                }
            }
        }
    }
}
