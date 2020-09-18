using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shushi_Go
{
    abstract class Card
    {
        //Records the area the card is drawn in
        protected Rectangle area_;
        //Images used to display the back of the cards
        protected Bitmap imageBack;
        //Front image will be provided by each subclass
        protected Bitmap imageFront;
        //String of information regading the card
        protected string cardInfo;

        //Constuctor
        public Card()
        { 
            imageBack = new Bitmap(@"..\..\..\Card_Images\Black_back_design.jpg", true);
        }

        /// <summary>
        /// Displays the image of the card
        /// </summary>
        public virtual void Display(Graphics paper, Rectangle area, bool faceUp)
        {
            area_ = area;
            if (faceUp)
            {
                paper.DrawImage(imageFront, area_);
            }
            else
            {
                paper.DrawImage(imageBack, area_);
            }
        }

        /// <summary>
        /// Provides the rules regading the card
        /// </summary>
        /// <returns>Information on each card</returns>
        public string Information()
        {
            return cardInfo;
        }

        /// <summary>
        /// Checks if the mouse clicked on this card
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsMouseOn(int x, int y)
        {
            if (area_.X <= x && x < area_.X + area_.Width
                && area_.Y <= y && y < area_.Y + area_.Height)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Doubles the size of clicked on card
        /// </summary>
        /// <param name="paper">The graphic to draw onto</param>
        /// <param name="User">Is this the user at the bottem of the screen</param>
        public void Highlight(Graphics paper, bool User, int muliplyWidth)
        {
            if (User)
            {
                area_.Y -= area_.Height;
            }
            else
            {
                area_.Width *= muliplyWidth;
            }
            area_.X -= area_.Width / 2;
            area_.Height *= 2;
            area_.Width *= 2;
            paper.DrawImage(imageFront, area_);
        }
    }
}
