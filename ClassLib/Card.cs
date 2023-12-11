using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLib.BLACKJACKiD;

namespace ClassLib
{
    class Card : iCard
    {        
        CardFace face;
        CardSuits suits;
        public Card( CardFace face, CardSuits suits)
        {
            this.face = face;//inFace   
            this.suits = suits;//inSuit
        }
        
        public CardFace getCardFace
        {
            get => face;
            
           
            private set { this.face = value; }
        }
        public CardSuits getCardSuits
        {
            get => suits;
                       
            private set { this.suits = value; }
        }
        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}
