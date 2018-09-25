using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changing_picture
{
    public partial class Form1 : Form
    {
        private Image geko;
        private Image zimbabwe;

        public Form1()
        {
            InitializeComponent();
            geko = Properties.Resources.geko;
            zimbabwe = Properties.Resources.zimbabwe;
        }

        private void geko_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image == geko)
            {
                PictureBox1.Image = zimbabwe;
            }
            else
            {
                PictureBox1.Image = geko;
            }
        }
    }
}
