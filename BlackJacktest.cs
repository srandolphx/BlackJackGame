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
                ReadChoice(prompt, menu_choices, out result);
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Coming Soon!");
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
        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            selection = ReadInt(prompt, 1, options.Length);
        }
    }
}
