
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLib.BLACKJACKiD;

namespace ClassLib
{
    public static class Factory
    {
        public static iCard makeCard(CardFace face, CardSuits suit)
        {
            iCard card = new Card(face, suit);
            return card;
        }
        public static iCard createBlackjackCard(CardFace face, CardSuits suit)
        {
            iCard BlackjackCard = new Card(face, suit);
            return BlackjackCard;
        }
    }
}
