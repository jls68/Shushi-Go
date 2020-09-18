using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shushi_Go
{
    class Nigiri : Card
    {
        //Amount of Maki rolls on card
        private int amount_;

        //Constructor
        public Nigiri(int amount)
        {
            amount_ = amount;
            imageFront = new Bitmap(@"..\..\..\Card_Images\nigiri_" + amount_.ToString() + ".jpg", true);
            cardInfo = "NIGIRI: A squid nigiri scores 3 points.A salmon nigiri scores 2 points.An egg nigiri scores 1 point." +
                " If a nigiri is put on a wasabi card then the score is tripled for that nigiri.";
        }

        /// <summary>
        /// Gets amount of points earned by this card
        /// </summary>
        public int Amount
        {
            get
            {
                return amount_;
            }
        }
    }
}