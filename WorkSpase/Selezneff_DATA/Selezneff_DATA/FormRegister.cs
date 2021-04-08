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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            textBoxName.Text = "  Имя";
            textBoxSurname.Text = "  Фамилия";
            comboBoxCountry.Text = "  Страна";
            comboBoxRank.Text = "  Звание";
            textBoxLogin.Text = "  Логин";
            textBoxPassword.Text = "  Пароль";
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "  Имя")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.White;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "  Имя";
                textBoxName.ForeColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            }
        }

        private void textBoxSurname_Enter(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "  Фамилия")
            {
                textBoxSurname.Text = "";
                textBoxSurname.ForeColor = Color.White;
            }
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "")
            {
                textBoxSurname.Text = "  Фамилия";
                textBoxSurname.ForeColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            }
        }

        private void comboBoxCountry_Enter(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text == "  Страна")
            {
                comboBoxCountry.Text = "";
                comboBoxCountry.ForeColor = Color.White;
            }
        }

        private void comboBoxCountry_Leave(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text == "")
            {
                comboBoxCountry.Text = "  Страна";
                comboBoxCountry.ForeColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            }
        }

        private void comboBoxRank_Enter(object sender, EventArgs e)
        {
            if (comboBoxRank.Text == "  Звание")
            {
                comboBoxRank.Text = "";
                comboBoxRank.ForeColor = Color.White;
            }
        }

        private void comboBoxRank_Leave(object sender, EventArgs e)
        {
            if (comboBoxRank.Text == "")
            {
                comboBoxRank.Text = "  Звание";
                comboBoxRank.ForeColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            }
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "  Логин")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.White;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "  Логин";
                textBoxLogin.ForeColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "  Пароль")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.White;
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

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            

            if ( (textBoxName.Text == "  Имя") || (textBoxSurname.Text == "  Фамилия") || (comboBoxCountry.Text == "  Страна") || (comboBoxRank.Text == "  Звание") || (textBoxLogin.Text == "  Логин") || (textBoxPassword.Text == "  Пароль"))
            {
                MessageBox.Show("Вы не заполнили все поля");
                return;
            }

            if (checkUser())
            {
                MessageBox.Show("Пользователь с таким логином уже имеется в базе");
                return;
            }

            ClassesDB.DataBase db = new ClassesDB.DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`, `country`, `rank`) VALUES (@lo, @pas, @na, @sna, @co, @ra);", db.GetConnection());

            command.Parameters.Add("@lo", MySqlDbType.VarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@na", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@sna", MySqlDbType.VarChar).Value = textBoxSurname.Text;
            command.Parameters.Add("@co", MySqlDbType.VarChar).Value = comboBoxCountry.Text;
            command.Parameters.Add("@ra", MySqlDbType.VarChar).Value = comboBoxRank.Text;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("аккаунт был внесен в базу");
                this.Close();
            }
            else
            {
                MessageBox.Show("ошибка регистрации");
            }

            db.closeConnection();
        }

        public bool checkUser()
        {
            ClassesDB.DataBase db = new ClassesDB.DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @Log ", db.GetConnection());
            command.Parameters.Add("@Log", MySqlDbType.VarChar).Value = textBoxLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                 return false;
            }
        }

    }
}
