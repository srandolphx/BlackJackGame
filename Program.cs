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
            string prompt = "Please Enter a Number From 1 - 3! ";
            int result = 0;
            bool list = false;           
            while (!list)
            {
                DisplayChoices();
                ReadChoice(prompt, menu_choices, out result);
                switch (result)
                {
                    case 1:
                        break;
                    case 2:                        
                        break;
                    case 6:
                        list = true;
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
