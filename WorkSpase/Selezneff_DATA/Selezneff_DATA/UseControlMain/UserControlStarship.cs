using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selezneff_DATA.UseControl
{
    public partial class UserControlStarship : UserControl
    {
        public UserControlStarship()
        {
            InitializeComponent();
            userControlStarshipModule1.Visible = false;
        }

        private void buttonStarshipModule_Click(object sender, EventArgs e)
        {
            userControlStarshipModule1.Visible = true;

        }

        private void userControlStarshipModule1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
