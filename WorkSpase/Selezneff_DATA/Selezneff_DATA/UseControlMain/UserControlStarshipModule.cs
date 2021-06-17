using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Selezneff_DATA.UseControlMain
{
    public partial class UserControlStarshipModule : UserControl
    {


        int j;

        public UserControlStarshipModule()
        {
            InitializeComponent();
   


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if ((textBoxSpeed.Text != "") && (textBoxDistance.Text != "") && (comboBoxLVL.Text != ""))
            {
                labelErrorMission.Text = "Ошибки миссии :  ---";
                labelInfoTime.Text = "Время затраченное на полет :  ---";

                int speed = Convert.ToInt32(textBoxSpeed.Text);
                int distance = Convert.ToInt32(textBoxDistance.Text);
                int lvl = Convert.ToInt32(comboBoxLVL.Text);
                int timeModule = 0;
                int fuelModule = 0;

                int State = 0;

                var Module = new List<InterfaceStarshipModule>();
                Module.Add(new UseControlMain.ClassesStarshipModule.ModuleLVL_1());
                Module.Add(new UseControlMain.ClassesStarshipModule.ModuleLVL_2());
                Module.Add(new UseControlMain.ClassesStarshipModule.ModuleLVL_3());

                int sizeListModule = Module.Count;

                for(int i = 0; i < sizeListModule; i++)
                {
                    if (lvl == i+1)
                    {
                        timeModule = Module[i].Move(distance, speed);
                        fuelModule = Module[i].FuelConsumption(distance);
                    }
                }

                if(timeModule == -1)
                {
                    labelErrorMission.Text = "Ошибки миссии :  \nзаданая скорость превыщает \nмаксимальную скорость этого модуля";
                    labelInfoTime.Text = "Время затраченное на полет :  ERROR";
                    labelFuel.Text = "Расход топлива :  ERROR";
                }
                else
                {
                    if (timeModule == -2)
                    {
                        labelErrorMission.Text = "Ошибки миссии :  \nзаданая дистанция превыщает \nмаксимальную дистанцию этого модуля";
                        labelInfoTime.Text = "Время затраченное на полет :  ERROR";
                        labelFuel.Text = "Расход топлива :  ERROR";
                    }
                    else
                    {
                        labelInfoTime.Text = "Время затраченное на полет :  " + timeModule.ToString();
                        ClassesProgram.DataBank.MissionCompletionTime = timeModule.ToString();
                        labelFuel.Text = "Расход топлива :  " + fuelModule.ToString() + "⛽";
                        ClassesProgram.DataBank.FuelСonsumption = fuelModule.ToString();
                    }
                }

                string[] ErrorModuleNormal = { "С хрустом но долетим", "Видал и хуже", "Долго мы не протянем", "СТО бы пройти" };//вариации ошибок модуля при нормальном его состоянии
                string[] ErrorModuleCritics = { "Отказал даже чайник", "Это финито", "Отмаливайте пасана", "Расчехляйся на ремонт" };//вариации ошибок модуля при требуемом ремонта состоянии

                var rand = new Random();
                var rep = new UseControlMain.ClassesStarshipModule.RepairCosts();

                switch (lvl)
                {
                    case 1:
                        State = Convert.ToInt32(ClassesProgram.DataBank.StateModule_1);// состояние модуля 1 уровня которое берется из DataBank в который попадает из 
                                                                                       // SQL базы индивидульно для каждого пользователя
                        switch (State)
                        {
                            case 1:
                                labelStateModule.Text = "Состояние модуля :  Отличное";
                                labelRepairCosts.Text = "Расход на ремонт :  ---";
                                labelMissionCompletionTime.Text = "Время до завершения миссии :  ---";
                                labelMissionResult.Text = "Результат миссии :  ---";
                                labelErrorModule.Text = "Ошибки модуля: ---";
                                break;
                            case 2:
                                labelStateModule.Text = "Состояние модуля :  Нормальное";
                                labelRepairCosts.Text = "Расход на ремонт :  " + rep.RepairCostsModule(lvl,State).ToString() + "$";
                                ClassesProgram.DataBank.RepairCosts = rep.RepairCostsModule(lvl, State).ToString();
                                labelMissionCompletionTime.Text = "Время до завершения миссии :  ---";
                                labelMissionResult.Text = "Результат миссии :  ---";
                                labelErrorModule.Text = "Ошибки модуля: " + ErrorModuleNormal[rand.Next(3)];
                                break;
                            case 3:
                                labelStateModule.Text = "Состояние модуля :  Требуется Ремонт";
                                labelRepairCosts.Text = "Расход на ремонт :  " + rep.RepairCostsModule(lvl, State).ToString() + "$";
                                ClassesProgram.DataBank.RepairCosts = rep.RepairCostsModule(lvl, State).ToString();
                                labelMissionCompletionTime.Text = "Время до завершения миссии :  ---";
                                labelMissionResult.Text = "Результат миссии :  ---";
                                labelErrorModule.Text = "Ошибки модуля: " + ErrorModuleCritics[rand.Next(3)];
                                break;
                        }

                        break;

                    case 2:
                        State = Convert.ToInt32(ClassesProgram.DataBank.StateModule_2);// состояние модуля 2 уровня которое берется из DataBank в который попадает из 
                                                                                       // SQL базы индивидульно для каждого пользователя

                        switch (State)
                        {
                            case 1:
                                labelStateModule.Text = "Состояние модуля :  Отличное";
                                labelRepairCosts.Text = "Расход на ремонт :  ---";
                                labelMissionCompletionTime.Text = "Время до завершения миссии :  ---";
                                labelMissionResult.Text = "Результат миссии :  ---";
                                labelErrorModule.Text = "Ошибки модуля: ---";
                                break;
                            case 2:
                                labelStateModule.Text = "Состояние модуля :  Нормальное";
                                labelRepairCosts.Text = "Расход на ремонт :  " + rep.RepairCostsModule(lvl, State).ToString() + "$";
                                ClassesProgram.DataBank.RepairCosts = rep.RepairCostsModule(lvl, State).ToString();
                                labelMissionCompletionTime.Text = "Время до завершения миссии :  ---";
                                labelMissionResult.Text = "Результат миссии :  ---";
                                labelErrorModule.Text = "Ошибки модуля: " + ErrorModuleNormal[rand.Next(3)];
                                break;
                            case 3:
                                labelStateModule.Text = "Состояние модуля :  Требуется Ремонт";
                                labelRepairCosts.Text = "Расход на ремонт :  " + rep.RepairCostsModule(lvl, State).ToString() + "$";
                                ClassesProgram.DataBank.RepairCosts = rep.RepairCostsModule(lvl, State).ToString();
                                labelMissionCompletionTime.Text = "Время до завершения миссии :  ---";
                                labelMissionResult.Text = "Результат миссии :  ---";
                                labelErrorModule.Text = "Ошибки модуля: " + ErrorModuleCritics[rand.Next(3)];
                                break;
                        }

                        break;

                    case 3:
                        State = Convert.ToInt32(ClassesProgram.DataBank.StateModule_3);// состояние модуля 3 уровня которое берется из DataBank в который попадает из 
                                                                                       // SQL базы индивидульно для каждого пользователя

                        switch (State)
                        {
                            case 1:
                                labelStateModule.Text = "Состояние модуля :  Отличное";
                                labelRepairCosts.Text = "Расход на ремонт :  ---";
                                labelMissionCompletionTime.Text = "Время до завершения миссии :  ---";
                                labelMissionResult.Text = "Результат миссии :  ---";
                                labelErrorModule.Text = "Ошибки модуля: ---";
                                break;
                            case 2:
                                labelStateModule.Text = "Состояние модуля :  Нормальное";
                                labelRepairCosts.Text = "Расход на ремонт :  " + rep.RepairCostsModule(lvl, State).ToString() + "$";
                                ClassesProgram.DataBank.RepairCosts = rep.RepairCostsModule(lvl, State).ToString();
                                labelMissionCompletionTime.Text = "Время до завершения миссии :  ---";
                                labelMissionResult.Text = "Результат миссии :  ---";
                                labelErrorModule.Text = "Ошибки модуля: " + ErrorModuleNormal[rand.Next(3)];
                                break;
                            case 3:
                                labelStateModule.Text = "Состояние модуля :  Требуется Ремонт";
                                labelRepairCosts.Text = "Расход на ремонт :  " + rep.RepairCostsModule(lvl, State).ToString() + "$";
                                ClassesProgram.DataBank.RepairCosts = rep.RepairCostsModule(lvl, State).ToString();
                                labelMissionCompletionTime.Text = "Время до завершения миссии :  ---";
                                labelMissionResult.Text = "Результат миссии :  ---";
                                labelErrorModule.Text = "Ошибки модуля: " + ErrorModuleCritics[rand.Next(3)];
                                break;
                        }

                        break;
                }
                
            }

            
        }

        private void UserControlStarshipModule_Load(object sender, EventArgs e)
        {

        }



        private void buttonRepair_Click(object sender, EventArgs e)
        {
            int lvl = Convert.ToInt32(comboBoxLVL.Text);
            int State = 0;
            int RepairCosts = Convert.ToInt32(ClassesProgram.DataBank.RepairCosts);
            int Money = Convert.ToInt32(ClassesProgram.DataBank.MoneyUser);
            var rep = new UseControlMain.ClassesStarshipModule.RepairCosts();

            switch (lvl)
            {
                case 1:
                    State = Convert.ToInt32(ClassesProgram.DataBank.StateModule_1);
                    switch (State)
                    {
                        case 1:

                            break;
                        case 2:
                            if ((Money-RepairCosts) > 0)
                            {
                                labelStateModule.Text = "Состояние модуля :  Отличное";
                                ClassesProgram.DataBank.StateModule_1 = "1";
                                labelRepairCosts.Text = "Расход на ремонт :  ---";
                                labelErrorModule.Text = "Ошибки модуля: ---";
                                ClassesProgram.DataBank.MoneyUser = (Money - RepairCosts).ToString();
                            }
                            else
                            {
                                labelErrorModule.Text = labelErrorModule.Text + ", \nНедостаточно средств на ремонт";
                            }                           
                            break;
                        case 3:
                            if ((Money - RepairCosts) > 0)
                            {
                                labelStateModule.Text = "Состояние модуля :  Отличное";
                                ClassesProgram.DataBank.StateModule_1 = "1";
                                labelRepairCosts.Text = "Расход на ремонт :  ---";
                                labelErrorModule.Text = "Ошибки модуля: ---";
                                ClassesProgram.DataBank.MoneyUser = (Money - RepairCosts).ToString();
                            }
                            else
                            {
                                labelErrorModule.Text = labelErrorModule.Text + ", \nНедостаточно средств на ремонт";
                            }
                            break;
                    }
                    break;
                case 2:
                    State = Convert.ToInt32(ClassesProgram.DataBank.StateModule_2);
                    switch (State)
                    {
                        case 1:

                            break;
                        case 2:
                            if ((Money - RepairCosts) > 0)
                            {
                                labelStateModule.Text = "Состояние модуля :  Отличное";
                                ClassesProgram.DataBank.StateModule_2 = "1";
                                labelRepairCosts.Text = "Расход на ремонт :  ---";
                                labelErrorModule.Text = "Ошибки модуля: ---";
                                ClassesProgram.DataBank.MoneyUser = (Money - RepairCosts).ToString();
                            }
                            else
                            {
                                labelErrorModule.Text = labelErrorModule.Text + ", \nНедостаточно средств на ремонт";
                            }
                            break;
                        case 3:
                            if ((Money - RepairCosts) > 0)
                            {
                                labelStateModule.Text = "Состояние модуля :  Отличное";
                                ClassesProgram.DataBank.StateModule_2 = "1";
                                labelRepairCosts.Text = "Расход на ремонт :  ---";
                                labelErrorModule.Text = "Ошибки модуля: ---";
                                ClassesProgram.DataBank.MoneyUser = (Money - RepairCosts).ToString();
                            }
                            else
                            {
                                labelErrorModule.Text = labelErrorModule.Text + ", \nНедостаточно средств на ремонт";
                            }
                            break;
                    }
                    break;
                case 3:
                    State = Convert.ToInt32(ClassesProgram.DataBank.StateModule_3);
                    switch (State)
                    {
                        case 1:

                            break;
                        case 2:
                            if ((Money - RepairCosts) > 0)
                            {
                                labelStateModule.Text = "Состояние модуля :  Отличное";
                                ClassesProgram.DataBank.StateModule_3 = "1";
                                labelRepairCosts.Text = "Расход на ремонт :  ---";
                                labelErrorModule.Text = "Ошибки модуля: ---";
                                ClassesProgram.DataBank.MoneyUser = (Money - RepairCosts).ToString();
                            }
                            else
                            {
                                labelErrorModule.Text = labelErrorModule.Text + ", \nНедостаточно средств на ремонт";
                            }
                            break;
                        case 3:
                            if ((Money - RepairCosts) > 0)
                            {
                                labelStateModule.Text = "Состояние модуля :  Отличное";
                                ClassesProgram.DataBank.StateModule_3 = "1";
                                labelRepairCosts.Text = "Расход на ремонт :  ---";
                                labelErrorModule.Text = "Ошибки модуля: ---";
                                ClassesProgram.DataBank.MoneyUser = (Money - RepairCosts).ToString();
                            }
                            else
                            {
                                labelErrorModule.Text = labelErrorModule.Text + ", \nНедостаточно средств на ремонт";
                            }
                            break;
                    }
                    break;
            }
        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            int Fuel = Convert.ToInt32(ClassesProgram.DataBank.Fuel);
            int FuelСonsumption = Convert.ToInt32(ClassesProgram.DataBank.FuelСonsumption);
            int MissionCompletionTime = Convert.ToInt32(ClassesProgram.DataBank.MissionCompletionTime);

            if ( ((Fuel - FuelСonsumption) > 0) && ((labelStateModule.Text == "Состояние модуля :  Отличное") || (labelStateModule.Text == "Состояние модуля :  Нормальное") ))
            {
                timer1.Enabled = true;
            }
            else
            {
                labelErrorModule.Text = labelErrorModule.Text + ", \nНедостаточно топлива на полет";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            j++;
            int MissionCompletionTime = Convert.ToInt32(ClassesProgram.DataBank.MissionCompletionTime);
            if (j == MissionCompletionTime)
            {
                timer1.Enabled = false;
                var resultRand = new Random();
                string[] result = { "изучен новый астероид", "открыто новое месторождение", "миссия не завершилась удачно", "мы нашли клад"};
                int res = resultRand.Next(3);
                if(res == 3)
                {
                    ClassesProgram.DataBank.MoneyUser = (Convert.ToInt32(ClassesProgram.DataBank.MoneyUser) + 1000).ToString();//при нахождении клада на счет пользователя ложиться 1000$
                }

                labelMissionResult.Text = "Результат миссии :  " + result[res];
                labelMissionCompletionTime.Text = "Время до завершения миссии : ---";
                j = 0;
            }
            labelMissionCompletionTime.Text = "Время до завершения миссии : " + j + "🚀c";

        }
    }
}
