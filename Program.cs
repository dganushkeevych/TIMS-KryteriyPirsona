using MathStatisticsPirsonWindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Перевірка гіпотези про біномний закон розпоілу
//КРИТЕРІЙ ПІРСОНА

namespace PirsonWindowsForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
