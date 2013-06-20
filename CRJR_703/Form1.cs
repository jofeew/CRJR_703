using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void técnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void pcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void escritorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }

        private void portátilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.MdiParent = this;
            form5.Show();
        }

        private void ordenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.MdiParent = this;
            form6.Show();
        }

        private void listadoOrdenTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.MdiParent = this;
            form7.Show();
        }

        private void listadoDeTécnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.MdiParent = this;
            form8.Show();
        }
    }
}
