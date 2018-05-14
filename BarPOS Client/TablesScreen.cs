// Bar POS, class TableScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton

using System.Drawing;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class TableScreen : Form
    {
        TableList Tables { get;}
        Image Image { get; set; }

        public TableScreen()
        {
            Image = this.picTables.Image;
            InitializeComponent();
        }
    }
}
