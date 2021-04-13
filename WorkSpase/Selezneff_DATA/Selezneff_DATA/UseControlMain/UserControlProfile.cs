using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selezneff_DATA
{
    public partial class UserControlProfile : UserControl
    {
        public UserControlProfile()
        {
            InitializeComponent();
        }

        private void UserControlProfile_Load(object sender, EventArgs e)
        {
            labelNameUser.Text = ClassesProgram.DataBank.NameUser;
            labelSurnameUser.Text = ClassesProgram.DataBank.SurnameUser;
            labelCountryUser.Text = ClassesProgram.DataBank.CountryUser;
            labelRankUser.Text = ClassesProgram.DataBank.RankUser;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelNameUser_Click(object sender, EventArgs e)
        {

        }
    }
}
