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
    public partial class UserControlTeam : UserControl
    {
        public UserControlTeam()
        {
            InitializeComponent();

            UseControlMain.ClassesTeam.ClassRobot robot = new UseControlMain.ClassesTeam.ClassRobot();
            UseControlMain.ClassesTeam.ClassHuman human = new UseControlMain.ClassesTeam.ClassHuman();
            UseControlMain.ClassesTeam.ClassAlien alien = new UseControlMain.ClassesTeam.ClassAlien();


            labelRobot.Text = robot.Race();
            labelHuman.Text = human.Race();
            labelAlien.Text = alien.Race();

            RobotSPECIAL.Text = robot.Skills_SPECIAL();
            HumanSPECIAL.Text = human.Skills_SPECIAL();
            AlienSPECIAL.Text = alien.Skills_SPECIAL();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AlienSPECIAL_Click(object sender, EventArgs e)
        {

        }
    }
}
