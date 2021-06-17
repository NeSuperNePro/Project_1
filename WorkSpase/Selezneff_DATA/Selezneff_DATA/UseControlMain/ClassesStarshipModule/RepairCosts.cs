using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selezneff_DATA.UseControlMain.ClassesStarshipModule
{
    class RepairCosts
    {
        public int RepairCostsModule(int lvl, int State)
        {
            return lvl * State * 10;
        }
    }
}
