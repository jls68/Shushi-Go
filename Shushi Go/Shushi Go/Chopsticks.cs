using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shushi_Go
{
    class Chopsticks : Card
    {
        //Constructor
        public Chopsticks()
        {
            imageFront = new Bitmap(@"..\..\..\Card_Images\chopsticks.jpg", true);
            cardInfo = "CLICK THE BUTTON BOTTEM RIGHT WHEN IT APPEARS TO USE CHOPSTICKS: Play this card normally but if you already have a chopsticks card in front"
                + " of you, you may swap it with another card in your hand before playing a different card"
                + " To do this first have a chopstick card played then on a following turn select a card but instead"
                + " of hitting the 'Play Card' button hit the 'Sushi Go!' button that will become visible, then continue your turn as normal."
                + " NOTE: You may have multiple chopsticks cards in front of you but may only use 1 per turn.";
        }

    }
}