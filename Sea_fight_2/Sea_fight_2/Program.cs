using System;
using System.Windows.Forms;

namespace Sea_fight_2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new StartForm());
        }
    }
}
