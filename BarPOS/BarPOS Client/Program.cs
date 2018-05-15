// Bar POS, class Program

// Versiones: 
// V0.01 15-May-2018 Moisés: TableScreen center to the window

using System;
using System.Windows.Forms;

namespace BarPOS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TableScreen tableScreen = new TableScreen();
            tableScreen.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(tableScreen);
        }
    }
}
