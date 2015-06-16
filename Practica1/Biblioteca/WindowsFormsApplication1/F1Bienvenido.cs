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
    public partial class F1Bienvenido : Form
    {
        public F1Bienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F2Carnet F2 = new F2Carnet();
            F2.getMain(this);
            F2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            F3Autor F3 = new F3Autor();
            F3.getMain(this);
            F3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            F4Libro F4 = new F4Libro();
            F4.getMain(this);
            F4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            F5Servicio F5 = new F5Servicio();
            F5.getMain(this);
            F5.Show();
        }
    }
}
