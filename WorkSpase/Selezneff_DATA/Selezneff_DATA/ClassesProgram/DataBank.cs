using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selezneff_DATA.ClassesProgram
{
    static class DataBank
    {
        public static int F;//флаг окна авторизации

        public static string ID;// id пользователья

        public static string NameUser;
        public static string SurnameUser;
        public static string CountryUser;
        public static string RankUser;

        public static string MoneyUser;//количество денег
        public static string Fuel;//количество топлива

//-------------------------------------------------------------------------------- UserControlStarshipModule
        public static string StateModule_1;// состояние модулей
        public static string StateModule_2;// 
        public static string StateModule_3;//
      
        public static string FuelСonsumption;//Расход топлива

        public static string MissionCompletionTime;//время до завершение миссии

        public static string RepairCosts;//расход на ремонт(для общения между классами)
 //--------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------- UserControlShop

        public static string BUY;// на покупку
        public static string SELL;// на покупку

        //--------------------------------------------------------------------------------
    }
}
