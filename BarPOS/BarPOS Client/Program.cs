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
            ConfigurationScreen configurationScreen = new ConfigurationScreen();
            configurationScreen.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(configurationScreen);
        }
    }
}
