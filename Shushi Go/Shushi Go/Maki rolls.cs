using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shushi_Go
{
    class Maki_rolls : Card
    {
        //Amount of Maki rolls on card
        private int icons_;

        //Constructor
        public Maki_rolls(int icons)
        {
            icons_ = icons;
            //Set image depending on value of icons
            //if (icons_ <= 1)
            //{
                imageFront = new Bitmap(@"..\..\..\Card_Images\maki_" + icons_.ToString() + ".jpg", true);
            //}
            //else if (icons_ == 2)
            //{
            //    imageFront = new Bitmap(@"..\..\..\Card_Images\maki_2.jpg", true);
            //}
            //else
            //{
            //    imageFront = new Bitmap(@"..\..\..\Card_Images\maki_3.png", true);
            //}

            cardInfo = "MAKI ROLLS: The player with"
                + " the most maki roll icons scores 6 points. If players tie for the most, they split the 6 points evenly(ignoring any remainder) and no second"
                + " place points are awarded. The player with the second most icons scores 3 points. If multiple players tie for second place, they split the"
                + " points evenly(ignoring any remainder).";
        }

        /// <summary>
        /// Gets amount of icons on this card
        /// </summary>
        public int Icons
        {
            get { return icons_; }
        }
    }
}
