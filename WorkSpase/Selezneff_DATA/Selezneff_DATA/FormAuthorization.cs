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
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxLogn.Text = "  Логин";
            textBoxPassword.Text = "  Пароль";
        }


            private void textBoxLogn_Enter(object sender, EventArgs e)
        {

            if (textBoxLogn.Text == "  Логин")
            {
                textBoxLogn.Text = "";
                textBoxLogn.ForeColor = Color.White;
            }

          
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "  Пароль")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.White;
            }
        }

        private void textBoxLogn_Leave(object sender, EventArgs e)
        {
            if (textBoxLogn.Text == "")
            {
                textBoxLogn.Text = "  Логин";
                textBoxLogn.ForeColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "  Пароль";
                textBoxPassword.ForeColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            String Login = textBoxLogn.Text;
            String Password = textBoxPassword.Text;

            ClassesDB.DataBase db = new ClassesDB.DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @Log AND `password` = @Pass", db.GetConnection());
            
            command.Parameters.Add("@Log", MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = Password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            

            if (table.Rows.Count > 0)
            {
                ClassesProgram.DataBank.F = 1;

                ClassesProgram.DataBank.ID = table.Rows[0][0].ToString();

                ClassesProgram.DataBank.NameUser = table.Rows[0][3].ToString();
                ClassesProgram.DataBank.SurnameUser = table.Rows[0][4].ToString();
                ClassesProgram.DataBank.CountryUser = table.Rows[0][5].ToString();
                ClassesProgram.DataBank.RankUser = table.Rows[0][6].ToString();

                ClassesProgram.DataBank.MoneyUser = table.Rows[0][7].ToString();

                ClassesProgram.DataBank.StateModule_1 = table.Rows[0][8].ToString();
                ClassesProgram.DataBank.StateModule_2 = table.Rows[0][9].ToString();
                ClassesProgram.DataBank.StateModule_3 = table.Rows[0][10].ToString();

                ClassesProgram.DataBank.Fuel = table.Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("Такой пользователь не найден");
            }
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            FormRegister reg = new FormRegister();            
            reg.Show();
        }

        private void FormAuthorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(ClassesProgram.DataBank.F != 1)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
            {
                Application.Exit();
            }

            
        }
    }
}
