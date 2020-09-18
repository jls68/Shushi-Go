using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shushi_Go
{
    class Hand
    {
        /// <summary>
        /// List of cards in this hand
        /// </summary>
        private List<Card> cardsInHand;

        public Hand(List<Card> cards)
        {
            cardsInHand = cards;
        }
    }
}
