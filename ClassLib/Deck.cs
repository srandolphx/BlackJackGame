using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLib.BLACKJACKiD;

namespace ClassLib
{
    public class Deck
    {
        public static string[] cardSymbols = new string[] { "♣", "♠", "♦", "♥", };
        private static List<iCard> _cards;
        public Deck()
        {
            _cards = new List<iCard>();
            generate();
          
        }
        public List<iCard> grabCards()
        {
            return _cards;
        }
        public static void generate()
        {
            
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    _cards.Add(Factory.createBlackjackCard((CardFace)j, (CardSuits)i));
                }
            }
        }        
        public void shuffleDECK()
        {
            Console.WriteLine("Shuffling Deck...");
            Random rnd = new Random(DateTime.Now.Millisecond);
            
            
           

            for(int i = 0; i <= _cards.Count; i++)
            {
                int randPos = rnd.Next(0, _cards.Count);
                iCard Temp = _cards[randPos]; 
                _cards.Remove(_cards[randPos]);
                _cards.Add(Temp);
                
            }
        }      
       public iCard deal()
        {
            iCard dealt = _cards.Last();
            _cards.Remove(_cards.Last());
            return dealt;
        }
        public void draw(int x, int y)
        {



            for (int i = 0; i < _cards.Count; i++)
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
        string getSymbol(int i)
        {
            if ((int)_cards[i].getCardSuits == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "♥";
            }
            else if ((int)_cards[i].getCardSuits == 1)
            {
                return "♣";
            }
            else if ((int)_cards[i].getCardSuits == 2)
            {
                return "♠";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "♦";
            }
        }
        string getFace(int i)
        {
            if ((int)_cards[i].getCardSuits == 11)
            {
                return "Jack";
            }
            else if ((int)_cards[i].getCardSuits == 12)
            {
                return "Queen";
            }
            else if ((int)_cards[i].getCardSuits == 13)
            {
                return "King";
            }
            else return _cards[i].getCardFace.ToString();
        }
    }
}
