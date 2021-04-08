using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Selezneff_DATA
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();

            this.BackgroundImage = pictureBox1.Image;
            pictureBox1.Visible = false;

            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
            this.TransparencyKey = Color.FromArgb(255, 255, 255);

            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .01;
            if (this.Opacity == 1)
            {

                timer1.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
