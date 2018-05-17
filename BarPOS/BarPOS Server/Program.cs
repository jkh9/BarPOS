using System;
using System.Windows.Forms;

namespace BarPOS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AdminScreen adminScreen = new AdminScreen();
            adminScreen.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(adminScreen);
        }
    }
}
