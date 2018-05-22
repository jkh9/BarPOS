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

        public SearchScreen()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TextToSearch = txtTextToSearch.Text;
            this.Close();
        }
    }
}
