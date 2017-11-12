using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_CEP
{
    public partial class Form1 : Form
    {

        int x, y;
        Point Point = new Point();

        public Form1()
        {
            InitializeComponent();
            string version = "Rhalf: version 1.0";
            label1.Text = version;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculador_cep_principal principal = new calculador_cep_principal();
            principal.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;

        }
    }
}
