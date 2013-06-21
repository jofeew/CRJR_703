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
    public partial class Form2 : Form
    {

        // se declara la conexión (?)
        string ruta = "server=localhost;User Id=root;password=sa;database=bd_crjr703";

        public Form2()
        {
            

            InitializeComponent();

            
            try
            {
                

                MySqlConnection con = new MySqlConnection(ruta);
                //abro la conexión
                con.Open();

                string consulta = "select * from tecnico";

                MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);

                // lleno el data set con la tabla de técnicos
                DataSet ds = new DataSet();
                da.Fill(ds, "tecnico");
                

                //muestro en el datagriew
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();


            }
            catch (Exception ee)
            {
                MessageBox.Show("se produjo un error debido a: " + ee.ToString());
            }

            
        }

        //INSERTAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "" && textBox1.Text.Trim() != "" && textBox2.Text.Trim() != ""
                && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(ruta);
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand();


                    string consulta = "insert into tecnico (rut,nombre,direccion,telefono,especialidad) values ('" + maskedTextBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";

                    //el cmd se comunica a traves de la linea de arriba
                    cmd.Connection = con;
                    cmd.CommandText = consulta;
                    cmd.ExecuteNonQuery();

                    //muestra el ingreso en el datagriew
                    string consulta2 = "select * from tecnico";
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta2, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tecnico");
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();



                }
                catch (Exception ee)
                {
                    MessageBox.Show("se produjo un error debido a " + ee.ToString());
                }

            }
            else {

                MessageBox.Show("Existen campos vacios, rellene todos los campos","Error", MessageBoxButtons.OK);
            }

        }


        //FUNCION ISNUMERIC
        private static bool IsNumeric(string value)
        {
            int number;
            return Int32.TryParse(value, out number);

        }





        // NAVEGACION POR ENTER
        //VALIDADO LOS CAMPOS NUMERICOS Y NO NUMERICOS
        //rut
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (13))
            {
                textBox1.Focus();
            }
        }

        //nombre
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
                    textBox1.Focus();
                }
            }
        }

        //direccion
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (13))
            {
                if (!IsNumeric(textBox2.Text.Trim()))
                {
                    textBox3.Focus();
                }
                else
                {
                    MessageBox.Show("ingrese solo letras");
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
        }

        //telefono
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (13))
            {
                if (IsNumeric(textBox3.Text.Trim()))
                {
                    textBox4.Focus();
                }
                else
                {
                    MessageBox.Show("ingrese solo letras");
                    textBox3.Clear();  
                }
            }
        }

        //especialidad
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (13))
            {
                 if (!IsNumeric(textBox4.Text.Trim()))
                {
                    maskedTextBox1.Focus();
                }
                else
                {
                    MessageBox.Show("ingrese solo letras");
                    textBox4.Clear();
                    textBox4.Focus();
                }
            }
        }

        //LIMPIAR
        private void button2_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Enabled = true;

        }

        // AL HACER CLICK QUE MUESTRE EN EL DATAGRID
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Enabled = false;
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            

        }


        // MODIFICAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != ""
                && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "")
            {
                try
                {

                    MySqlConnection con = new MySqlConnection(ruta);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    //string consulta = "update tecnico set (nombre,direccion,telefono,especialidad) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') where rut = '"+maskedTextBox1.Text+"'";

                    string consulta = "update tecnico set rut = '"+maskedTextBox1.Text+"' ,nombre ='"+textBox1.Text+"', direccion = '"+textBox2.Text+"', telefono = '"+textBox3.Text+"', especialidad = '"+textBox4.Text+"' where rut = '"+maskedTextBox1.Text+"'";


                    //el cmd se comunica a traves de la linea de arriba
                    cmd.Connection = con;
                    cmd.CommandText = consulta;
                    cmd.ExecuteNonQuery();


                    string consulta2 = "select * from tecnico";
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta2, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tecnico");
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();


                }
                catch (Exception ee)
                {
                    MessageBox.Show("Se produjo un error debido a : " + ee.ToString());
                }
            }
            else { 
                MessageBox.Show("Existe espacios vacios");
            }
        }
    }
}
