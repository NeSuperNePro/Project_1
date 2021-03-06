using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selezneff_DATA.UseControlMain.ClassesStarshipModule
{
    class ModuleLVL_2 : InterfaceStarshipModule
    {
        readonly int MaxSpeed = 100;
        readonly int MaxDistance = 1000;
        readonly int LVL = 2;

        public int FuelConsumption(int distance)
        {
            return Convert.ToInt32((LVL * 10 / distance) * 100);
        }

        public int Move(int distance, int speed)
        {
            if (speed > MaxSpeed)
            {
                return -1;// "заданая скорость превыщает максимальную скорость этого модуля"
            }
            if (distance > MaxDistance)
            {
                return -2;// "заданая дистанция превыщает максимальную дистанцию этого модуля"
            }

            return Convert.ToInt32(distance / speed);
        }
    }
}
