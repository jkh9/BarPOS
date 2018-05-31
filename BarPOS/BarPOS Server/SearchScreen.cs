// Bar POS, class SearchScreen

// Versiones: 
// V0.01 22-May-2018 Moisés: Class implemented

using System;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class SearchScreen : Form
    {
        public string TextToSearch { get; set; }

        public SearchScreen(Languajes languaje)
        {
            InitializeComponent();
            drawTexts(languaje);
        }

        private void drawTexts(Languajes languaje)
        {
            switch (languaje)
            {
                case Languajes.Castellano:
                    lblText.Text = "Texto de búsqueda";
                    btnSearch.Text = "Buscar";
                    break;
                case Languajes.English:
                    lblText.Text = "Text to search";
                    btnSearch.Text = "Search";
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TextToSearch = txtTextToSearch.Text;
            this.Close();
        }
    }
}
