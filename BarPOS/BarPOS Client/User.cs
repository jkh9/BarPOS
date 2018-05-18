// Bar POS, class User

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 18-May-2018 Moisés: Method ToString

using System;


namespace BarPOS
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return Name + "·" + Code + "·" + ImagePath;
        }
    }
}
