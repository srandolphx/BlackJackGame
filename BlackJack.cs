using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLACKJACK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Hand hand = new Hand();
            Deck deck = new Deck();
            string prompt = "Please Enter a Number From 1 - 3! ";
            int result = 0;
            bool Exit = false;
            while (!Exit)
            {
                DisplayChoices();
                ReadChoice(prompt, menu_choices.Length, out result);
                switch (result)
                {
                    case 1:
                        Console.WriteLine("heres your hand...");                        
                        bool round = false;
                        while (!round)
                        {
                            round = rounds();
                        }
                        break;
                    case 2:
                        Console.WriteLine();
                        deck.shuffleDECK();
                        deck.draw(100, 200);
                        break;
                    case 3:
                        Exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
        public static bool rounds()
        {

            Deck deck = new Deck();


            bool turn = false;
            int answer;
            //string[] options = new string[] { "1. Hit", "2.Stand" };

            BlackjackHand dealer = new BlackjackHand(true);
            BlackjackHand player = new BlackjackHand();

            deck.shuffleDECK();

            dealer.addCard(deck.deal());
            player.addCard(deck.deal());
            dealer.addCard(deck.deal());
            player.addCard(deck.deal());

            while (!turn)
            {
                if (player.Score == 21)
                {
                    break;

                }
                Console.Clear();
                board(dealer, player);
                ReadChoice("\nEnter 1 to hit or 2 to stand: ", 2, out answer);
               

                Console.Write(player.Score);

                if (answer == 1 )
                {
                    player.addCard(deck.deal());
                   
                }
                else break;
                

                if (player.Score > 21)
                {
                    break;
                   
                }
               
            }

            if (!turn)
            {
                turn = false;
                
                while (!turn)
                {
                    if (player.Score > dealer.Score)
                    {
                        dealer.addCard(deck.deal());
                    }
                    else if (player.Score == dealer.Score)
                    {
                        Console.WriteLine("\n\nDealer wins");
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

            }
           
         
            
            exitBoard(dealer, player);
            ReadChoice("\nEnter 1 to play again or 2 to exit: ", 2, out answer);

            if (answer == 2)
            {
                Console.Clear();
                return true;
                
            }
            return false;

        }
        public static string[] menu_choices = new string[]
        {
              "1. Play Blacjjack", "2. Shuffle & Show Deck", "3. Exit"
        };
        static void DisplayChoices()
        {
            for (int i = 0; i < menu_choices.Length; i++)
            {
                Console.WriteLine(menu_choices[i]);
            }
        }
        public static int ReadInt(string prompt, int min, int max)
        {
            Console.Write(prompt);
            int result;
            object _read = Console.ReadLine();
            bool _parsed = int.TryParse(_read.ToString(), out result);
            while (!_parsed || result < min || result > max)
            {
                if (!_parsed)
                {
                    Console.WriteLine("input a integer");
                }
                else
                {
                    Console.WriteLine("integer not in range!");
                }
                Console.Write(prompt);

                _read = Console.ReadLine();
                _parsed = int.TryParse(_read.ToString(), out result);
            }
            return result;
        }
        public static void ReadChoice(string prompt, int options, out int selection)
        {
            selection = ReadInt(prompt, 1, options);
        }
        public static void board(BlackjackHand dealer, BlackjackHand player)
        {
            int x = 0, y = 0;
            
            player.draw(x, y);
            Console.WriteLine($"\t{player.Score}");

            y = 15;

            dealer.IsDealer = true;
            dealer.draw(x, y);
        }
        public static void exitBoard(BlackjackHand dealer, BlackjackHand player)
        {
            int x = 0, y = 0;

            player.draw(x, y);
            Console.WriteLine($"\t{player.Score}");


            y = 15;
            dealer.IsDealer = false;
            dealer.draw(x, y);
            Console.WriteLine($"\t{dealer.Score}");

            if (dealer.Score < player.Score && player.Score <= 21 || dealer.Score > 21)
            {
                Console.WriteLine("Your the greatest!");
            }
            else if (dealer.Score > player.Score && dealer.Score<= 21 || player.Score > 21)
            {
                Console.WriteLine("The Dealer Wins!");
            }
            else Console.WriteLine("The Dealer Wins!");
        }

    }
}
