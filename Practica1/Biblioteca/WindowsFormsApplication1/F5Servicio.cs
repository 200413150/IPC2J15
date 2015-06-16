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
    public partial class F5Servicio : Form
    {
        F1Bienvenido F1 = new F1Bienvenido();
        public F5Servicio()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            comboBox2.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            comboBox4.Text = "";
            comboBox3.Text = "";
            comboBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            F1.Show();
        }

        public void getMain(F1Bienvenido Fmain)
        {
            F1 = Fmain;
        }
    }
}
