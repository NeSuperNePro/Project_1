using MySql.Data.MySqlClient;
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            ClassesDB.DataBase db = new ClassesDB.DataBase();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `money`= @money ,`StateModule_1`= @StateModule_1 ," +
                "`StateModule_2`= @StateModule_2 ,`StateModule_3`= @StateModule_3 ,`Fuel`= @Fuel  WHERE ID = @ID;", db.GetConnection());

            command.Parameters.Add("@money", MySqlDbType.VarChar).Value = ClassesProgram.DataBank.MoneyUser;
            command.Parameters.Add("@StateModule_1", MySqlDbType.VarChar).Value = ClassesProgram.DataBank.StateModule_1;
            command.Parameters.Add("@StateModule_2", MySqlDbType.VarChar).Value = ClassesProgram.DataBank.StateModule_2;
            command.Parameters.Add("@StateModule_3", MySqlDbType.VarChar).Value = ClassesProgram.DataBank.StateModule_3;
            command.Parameters.Add("@Fuel", MySqlDbType.VarChar).Value = ClassesProgram.DataBank.Fuel;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = ClassesProgram.DataBank.ID;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {

            }
            else
            {

            }

            db.closeConnection();
        }
    }
}
