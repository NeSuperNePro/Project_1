using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selezneff_DATA
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormStart first = new FormStart();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(5);
            first.Show();
            while ( end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();

            FormAuthorization au = new FormAuthorization();
            au.Show();
            while (ClassesProgram.DataBank.F != 1)
            {
                Application.DoEvents();
            }
            au.Close();
            au.Dispose();

            Application.Run(new FormMain());
        }
    }
}
