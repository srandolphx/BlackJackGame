using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLib.BLACKJACKiD;

namespace ClassLib
{
    public class BlackjackHand : Hand
    {
        public int Score { get; set; }        
        private bool isDealer = false;

       public BlackjackHand(bool IsDealer = false)
       {
            isDealer = IsDealer;
            Console.WriteLine("Dealer Hand");
       }
        public override void addCard(iCard card)
        {
            base.addCard(card);

            if (card.getCardFace == BLACKJACKiD.CardFace.Jack || card.getCardFace == BLACKJACKiD.CardFace.King || card.getCardFace == BLACKJACKiD.CardFace.Queen)
            {
                Score += 10;
            }
            else if (card.getCardFace != BLACKJACKiD.CardFace.Ace) 
            {
               
                Score += (int)card.getCardFace; 
            }                    
            else if (Score <= 21)
            {                     
                        Score += 11;                                   
            }
            if(Score > 21)
            {
                for (int i = 0; i < hand.Count; i++)
                {
                     if (hand[i].getCardFace == BLACKJACKiD.CardFace.Ace)
                    {
                        
                        Score -= 10;
                    }

                }
            }
        }
       
        public override void draw(int x, int y)
        {
            base.draw(x, y);
            
        }
        void cardBase(int i)
        {
            string bigshort = getFace(i);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("+---------------+");
            Console.WriteLine("|       " + getSymbol(i) + "       |");
            Console.WriteLine("|               |");
            Console.WriteLine("|       " + bigshort.PadRight(8) + "|");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            Console.WriteLine("+---------------+");
            Console.ResetColor();

        }
        void emptyCard()
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("+---------------+");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            Console.WriteLine("+---------------+");
            Console.ResetColor();

        }

        string getSymbol(int i)
        {
            if ((int)hand[i].getCardSuits == 0)
            {
                return "♥";
            }
            else if ((int)hand[i].getCardSuits == 1)
            {
                return "♣";
            }
            else if ((int)hand[i].getCardSuits == 2)
            {
                return "♠";
            }
            else
            {
                return "♦";
            }
        }
        string getFace(int i)
        {
            if ((int)hand[i].getCardSuits == 11)
            {
                return "jack";
            }
            else if ((int)hand[i].getCardSuits == 12)
            {
                return "Queen";
            }
            else if ((int)hand[i].getCardSuits == 13)
            {
                return "King";
            }
            else return hand[i].getCardFace.ToString();
        }
    }
        
        
}
