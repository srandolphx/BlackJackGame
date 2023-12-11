using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class BLACKJACKiD
    {
        public enum CardFace
        {
            Ace = 1,
            Two, 
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
        }
        public enum CardSuits
        {
            Hearts,
            Clubs,
            Spades,
            Diamonds
        }      
        public interface iCard
        {
            CardFace getCardFace
            {
                get;  
            }
            CardSuits getCardSuits
            {
                get;  
            }
            void Draw(int x, int y);
        }    
    }
}
