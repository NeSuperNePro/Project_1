using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selezneff_DATA.UseControlMain.ClassesShop
{
    class ClassShopSort
    {

        public System.Data.DataTable SortDown(System.Data.DataTable tabel)
        {
            int bufBuy;
            int bufSell;
            string bufName;

            for (int i = 0; i < tabel.Rows.Count; i++)
            {
                for (int j = i+1; j < tabel.Rows.Count; j++)
                {
                    if (Convert.ToInt32(tabel.Rows[j][2]) > Convert.ToInt32(tabel.Rows[i][2]))
                    {
                        bufName = tabel.Rows[i][1].ToString();
                        tabel.Rows[i][1] = tabel.Rows[j][1];
                        tabel.Rows[j][1] = bufName;

                        bufBuy = Convert.ToInt32(tabel.Rows[i][2]);
                        tabel.Rows[i][2] = tabel.Rows[j][2];
                        tabel.Rows[j][2] = bufBuy;

                        bufSell = Convert.ToInt32(tabel.Rows[i][3]);
                        tabel.Rows[i][3] = tabel.Rows[j][3];
                        tabel.Rows[j][3] = bufSell;
                    }
                }
            }
            return tabel;
        }

        public System.Data.DataTable SortUp(System.Data.DataTable tabel)
        {
            int bufBuy;
            int bufSell;
            string bufName;

            for (int i = 0; i < tabel.Rows.Count; i++)
            {
                for (int j = i + 1; j < tabel.Rows.Count; j++)
                {
                    if (Convert.ToInt32(tabel.Rows[j][2]) < Convert.ToInt32(tabel.Rows[i][2]))
                    {
                        bufName = tabel.Rows[i][1].ToString();
                        tabel.Rows[i][1] = tabel.Rows[j][1];
                        tabel.Rows[j][1] = bufName;

                        bufBuy = Convert.ToInt32(tabel.Rows[i][2]);
                        tabel.Rows[i][2] = tabel.Rows[j][2];
                        tabel.Rows[j][2] = bufBuy;

                        bufSell = Convert.ToInt32(tabel.Rows[i][3]);
                        tabel.Rows[i][3] = tabel.Rows[j][3];
                        tabel.Rows[j][3] = bufSell;
                    }
                }
            }
            return tabel;
        }

        
    }
}
