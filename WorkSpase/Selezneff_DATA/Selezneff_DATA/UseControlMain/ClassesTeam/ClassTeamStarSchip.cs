using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selezneff_DATA.UseControlMain.ClassesTeam
{
   abstract class ClassTeamStarSchip    // члена экипажа
    {
        public virtual string Race()
        {
            string race = "члена экипажа";
            return race;
        }

        public abstract string Skills_SPECIAL();  // абстрактный кдасс особых способностей

    }

    class ClassRobot : ClassTeamStarSchip  // переопределения члена экипажа в робота
    {
        public override string Race()
        {
            string race = "робот";
            return race;       
        }

        public override string Skills_SPECIAL()  // конкретизация особых способностей робота
        {
            int Strenght = 5;       // Сила
            int Perception = 0;     // Восприятие
            int Endurance = 9;      // Выносливость
            int Charisma = 0;       // Харизма
            int Intelligence = 7;  // Интелект
            int Agility = 0;        // Ловкость
            int Luck = 0;           // Удача       

            string SPECIAL = (Strenght.ToString() + ' ' + Perception + ' ' + Endurance + ' ' + Charisma + ' ' + Intelligence + ' ' + Agility + ' ' + Luck);

            return SPECIAL;
        }
    }

    class ClassHuman : ClassTeamStarSchip  // переопределения члена экипажа в человека
    {
        public override string Race()
        {
            string race = "человек";
            return race;
        }

        public override string Skills_SPECIAL()  // конкретизация особых способностей человека
        {
            int Strenght = 3;       // Сила
            int Perception = 5;     // Восприятие
            int Endurance = 5;      // Выносливость
            int Charisma = 5;       // Харизма
            int Intelligence = 6;  // Интелект
            int Agility = 5;        // Ловкость
            int Luck = 7;           // Удача       

            string SPECIAL = (Strenght.ToString() + ' ' + Perception + ' ' + Endurance + ' ' + Charisma + ' ' + Intelligence + ' ' + Agility + ' ' + Luck);

            return SPECIAL;
        }
    }

    class ClassAlien : ClassTeamStarSchip  // переопределения члена экипажа в инопланетянина
    {
        public override string Race()
        {
            string race = "инопланетянин";
            return race;
        }

        public override string Skills_SPECIAL()  // конкретизация особых способностей инопланетянина
        {
            int Strenght = 7;       // Сила
            int Perception = 7;     // Восприятие
            int Endurance = 3;      // Выносливость
            int Charisma = 2;       // Харизма
            int Intelligence = 2;  // Интелект
            int Agility = 3;        // Ловкость
            int Luck = 3;           // Удача       

            string SPECIAL = (Strenght.ToString() + ' ' + Perception + ' ' + Endurance + ' ' + Charisma + ' ' + Intelligence + ' ' + Agility + ' ' + Luck);

            return SPECIAL;
        }
    }
}
