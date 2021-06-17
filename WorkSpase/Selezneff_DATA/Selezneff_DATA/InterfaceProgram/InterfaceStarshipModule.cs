using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selezneff_DATA
{
    interface InterfaceStarshipModule
    {
        int Move(int distance, int speed);//выполняет перемещение на дистанцию с определенной скоростью и возвращает затрату на время

        int FuelConsumption(int distance);//затраты топлива на полет
    }
}
