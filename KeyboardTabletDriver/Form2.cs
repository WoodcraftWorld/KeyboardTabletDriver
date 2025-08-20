using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardTabletDriver
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public int KeyNumber = 0;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            int x = e.X;
            int y = e.Y;

            textBox1.Text = $"x={x};y={y};break;";
            Clipboard.SetText(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
