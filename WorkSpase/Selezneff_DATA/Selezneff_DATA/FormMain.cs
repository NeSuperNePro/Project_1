using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selezneff_DATA
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            userControlProfile1.Visible = true;
            userControlShop1.Visible = false;
            userControlStarship1.Visible = false;
            userControlTeam1.Visible = false;
            userControlProgramInfo1.Visible = false;
        }



        private void buttonProfile_Click(object sender, EventArgs e)
        {
            userControlProfile1.Visible = true;
            userControlShop1.Visible = false;
            userControlStarship1.Visible = false;
            userControlTeam1.Visible = false;
            userControlProgramInfo1.Visible = false;
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            userControlProfile1.Visible = false;
            userControlShop1.Visible = true;
            userControlStarship1.Visible = false;
            userControlTeam1.Visible = false;
            userControlProgramInfo1.Visible = false;
        }

        private void buttonStarship_Click(object sender, EventArgs e)
        {
            userControlProfile1.Visible = false;
            userControlShop1.Visible = false;
            userControlStarship1.Visible = true;
            userControlTeam1.Visible = false;
            userControlProgramInfo1.Visible = false;
        }

        private void buttonTeam_Click(object sender, EventArgs e)
        {
            userControlProfile1.Visible = false;
            userControlShop1.Visible = false;
            userControlStarship1.Visible = false;
            userControlTeam1.Visible = true;
            userControlProgramInfo1.Visible = false;
        }

        private void buttonProgramInfo_Click(object sender, EventArgs e)
        {
            userControlProfile1.Visible = false;
            userControlShop1.Visible = false;
            userControlStarship1.Visible = false;
            userControlTeam1.Visible = false;
            userControlProgramInfo1.Visible = true;
        }
    }
}
