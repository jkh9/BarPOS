// Bar POS, class User

// Versiones: 
// V0.01 14-May-2018 Mois�s: Basic skeleton

using System;
using System.Drawing;


namespace BarPOS
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public Image Image { get; set; }
    }
}
