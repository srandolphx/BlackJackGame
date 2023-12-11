using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLib.BLACKJACKiD;

namespace ClassLib
{
    public class Hand
    {
        protected List<iCard> hand = new List<iCard>();
       
        public virtual void addCard(iCard card)
        {
            hand.Add(card);
        }
        public virtual void draw(int x, int y)
        {

            for (int i = 0; i < hand.Count; i++)
            {

                cardBase(i);

            }
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
