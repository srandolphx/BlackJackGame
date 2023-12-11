using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLib.BLACKJACKiD;

namespace ClassLib
{
    class BlackjackCard : Card
    {
        public int Value { get; set; }
        public BlackjackCard(CardFace face, CardSuits suit) : base(face, suit)
        {
            if(face.ToString() == "King" || face.ToString() == "Queen" || face.ToString() == "Jack")
            {
                Value = 10;
            }
            else if(face.ToString() == "Ace")
            {
                Value = 11;
            }
            else
            {
                Value = (int)face;
            }           
        } 
    }
}
