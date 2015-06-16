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
    public partial class F4Libro : Form
    {
        F1Bienvenido F1 = new F1Bienvenido();
        public F4Libro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.Focus();
        }

        public void getMain(F1Bienvenido Fmain)
        {
            F1 = Fmain;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            F1.Show();
        }
    }
}
