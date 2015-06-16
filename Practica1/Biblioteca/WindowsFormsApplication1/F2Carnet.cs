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
    public partial class F2Carnet : Form
    {
        F1Bienvenido F1 = new F1Bienvenido();
        public F2Carnet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
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
