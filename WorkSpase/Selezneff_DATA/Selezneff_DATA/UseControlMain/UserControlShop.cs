using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

delegate DataTable up(DataTable tabel);
delegate DataTable down(DataTable tabel);


namespace Selezneff_DATA
{
    public partial class UserControlShop : UserControl
    {
        event up MyEventUp = null;

        public UserControlShop()
        {
            InitializeComponent();
        }

        private void buttonProductAvailability_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.Text != "")
            {
                ClassesDB.DataBase db = new ClassesDB.DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();


                textBoxInfo.Text = "";
                string[] ProductNameProgram = { "Топливо", "Компоненты", "Компьютеры", "Биомасса", "Топливный Генератор", "Космическая карта", "Космический ускоритель", "Варп Двигатель" };
                string[] ProductNameSQL = { "Fuel", "Components", "Computers", "Biomass", "FuelGenerator", "SpaceMap", "SpaceAccelerator", "WarpEngine" };

                MySqlCommand command = new MySqlCommand("SELECT * FROM `shop` WHERE `name_product` = @ProductNameSQL", db.GetConnection());

                for (int i = 0; i < ProductNameProgram.Length; i++)
                {
                    if (comboBoxProduct.Text == ProductNameProgram[i])
                    {
                        command.Parameters.Add("@ProductNameSQL", MySqlDbType.VarChar).Value = ProductNameSQL[i];
                    }
                }

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    textBoxInfo.Text = "Продукт : " + comboBoxProduct.Text + Environment.NewLine;
                    textBoxInfo.Text = textBoxInfo.Text + "Купить : " + table.Rows[0][2].ToString() + "$" + Environment.NewLine;
                    ClassesProgram.DataBank.BUY = table.Rows[0][2].ToString();
                    textBoxInfo.Text = textBoxInfo.Text + "Продать : " + table.Rows[0][3].ToString() + "$" + Environment.NewLine;
                    ClassesProgram.DataBank.SELL = table.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("Такой продукт не найден");
                }


            }
        }

        private void buttonBUY_Click(object sender, EventArgs e)
        {
            if(comboBoxProduct.Text != "")
            {
                if ((Convert.ToInt32(ClassesProgram.DataBank.MoneyUser) - Convert.ToInt32(ClassesProgram.DataBank.BUY)) >= 0)
                {
                    ClassesProgram.DataBank.MoneyUser = (Convert.ToInt32(ClassesProgram.DataBank.MoneyUser) - Convert.ToInt32(ClassesProgram.DataBank.BUY)).ToString();
                    textBoxInfo.Text = textBoxInfo.Text + Environment.NewLine + "Куплена 1 шт " + Environment.NewLine;
                }
            }  
        }

        private void buttonSELL_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.Text != "")
            {
                if ((Convert.ToInt32(ClassesProgram.DataBank.MoneyUser) + Convert.ToInt32(ClassesProgram.DataBank.SELL)) >= 0)
                {
                    ClassesProgram.DataBank.MoneyUser = (Convert.ToInt32(ClassesProgram.DataBank.MoneyUser) + Convert.ToInt32(ClassesProgram.DataBank.SELL)).ToString();
                    textBoxInfo.Text = textBoxInfo.Text + Environment.NewLine + "Продана 1 шт " + Environment.NewLine;
                }
            }            
        }

        private void buttonClearConsole_Click(object sender, EventArgs e)
        {        
            textBoxInfo.Text = "";
        }

        private void buttonSortProductUP_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "До сортировки:" + Environment.NewLine + "--------------------------" + Environment.NewLine;

            ClassesDB.DataBase db = new ClassesDB.DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `shop` WHERE `name_product` IS NOT NULL AND `BUY` IS NOT NULL AND `SELL` IS NOT NULL ORDER BY `id_product` ASC", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                string[] ProductNameProgram = { "Топливо", "Компоненты", "Компьютеры", "Биомасса", "Топливный Генератор", "Космическая карта", "Космический ускоритель", "Варп Двигатель" };
                string[] ProductNameSQL = { "Fuel", "Components", "Computers", "Biomass", "FuelGenerator", "SpaceMap", "SpaceAccelerator", "WarpEngine" };

                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < ProductNameProgram.Length; j++)
                    {
                        if (table.Rows[i][1].ToString() == ProductNameSQL[j])
                        {
                            textBoxInfo.Text = textBoxInfo.Text + "Продукт: " + ProductNameProgram[j] + Environment.NewLine;
                        }
                    }

                    textBoxInfo.Text = textBoxInfo.Text + "Купить: " + table.Rows[i][2].ToString() + "$" + Environment.NewLine;
                    textBoxInfo.Text = textBoxInfo.Text + "Продать: " + table.Rows[i][3].ToString() + "$" + Environment.NewLine;

                    textBoxInfo.Text = textBoxInfo.Text + Environment.NewLine;
                }

                textBoxInfo.Text = textBoxInfo.Text + "--------------------------" + Environment.NewLine + Environment.NewLine + Environment.NewLine + 
                                   "После сортировки:" + Environment.NewLine + "--------------------------" + Environment.NewLine;

                //UP
                UseControlMain.ClassesShop.ClassShopSort Sort = new UseControlMain.ClassesShop.ClassShopSort();
                up sortup = Sort.SortUp;
                MyEventUp += sortup;
                table = MyEventUp(table);

                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < ProductNameProgram.Length; j++)
                    {
                        if (table.Rows[i][1].ToString() == ProductNameSQL[j])
                        {
                            textBoxInfo.Text = textBoxInfo.Text + "Продукт: " + ProductNameProgram[j] + Environment.NewLine;
                        }
                    }

                    textBoxInfo.Text = textBoxInfo.Text + "Купить: " + table.Rows[i][2].ToString() + "$" + Environment.NewLine;
                    textBoxInfo.Text = textBoxInfo.Text + "Продать: " + table.Rows[i][3].ToString() + "$" + Environment.NewLine;

                    textBoxInfo.Text = textBoxInfo.Text + Environment.NewLine;
                }
            }
        }



        private void buttonSortProductDOWN_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "До сортировки:" + Environment.NewLine + "--------------------------" + Environment.NewLine;

            ClassesDB.DataBase db = new ClassesDB.DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `shop` WHERE `name_product` IS NOT NULL AND `BUY` IS NOT NULL AND `SELL` IS NOT NULL ORDER BY `id_product` ASC", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                string[] ProductNameProgram = { "Топливо", "Компоненты", "Компьютеры", "Биомасса", "Топливный Генератор", "Космическая карта", "Космический ускоритель", "Варп Двигатель" };
                string[] ProductNameSQL = { "Fuel", "Components", "Computers", "Biomass", "FuelGenerator", "SpaceMap", "SpaceAccelerator", "WarpEngine" };

                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < ProductNameProgram.Length; j++)
                    {
                        if (table.Rows[i][1].ToString() == ProductNameSQL[j])
                        {
                            textBoxInfo.Text = textBoxInfo.Text + "Продукт: " + ProductNameProgram[j] + Environment.NewLine;
                        }
                    }

                    textBoxInfo.Text = textBoxInfo.Text + "Купить: " + table.Rows[i][2].ToString() + "$" + Environment.NewLine;
                    textBoxInfo.Text = textBoxInfo.Text + "Продать: " + table.Rows[i][3].ToString() + "$" + Environment.NewLine;

                    textBoxInfo.Text = textBoxInfo.Text + Environment.NewLine;
                }

                textBoxInfo.Text = textBoxInfo.Text + "--------------------------" + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                                   "После сортировки:" + Environment.NewLine + "--------------------------" + Environment.NewLine;

                //DOWN

                UseControlMain.ClassesShop.ClassShopSort Sort = new UseControlMain.ClassesShop.ClassShopSort();
                down sortdown = Sort.SortDown;

                table = sortdown(table);

                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < ProductNameProgram.Length; j++)
                    {
                        if (table.Rows[i][1].ToString() == ProductNameSQL[j])
                        {
                            textBoxInfo.Text = textBoxInfo.Text + "Продукт: " + ProductNameProgram[j] + Environment.NewLine;
                        }
                    }

                    textBoxInfo.Text = textBoxInfo.Text + "Купить: " + table.Rows[i][2].ToString() + "$" + Environment.NewLine;
                    textBoxInfo.Text = textBoxInfo.Text + "Продать: " + table.Rows[i][3].ToString() + "$" + Environment.NewLine;

                    textBoxInfo.Text = textBoxInfo.Text + Environment.NewLine;
                }
            }
        }
    }
}
