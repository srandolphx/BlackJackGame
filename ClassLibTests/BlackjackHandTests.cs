using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {
        [TestMethod()]
        public void addCardTest()
        {
            BlackjackHand blackJackhand = new BlackjackHand (false);

            blackJackhand.addCard(Factory.makeCard(BLACKJACKiD.CardFace.Eight, BLACKJACKiD.CardSuits.Hearts));

            blackJackhand.addCard(Factory.makeCard(BLACKJACKiD.CardFace.Ace, BLACKJACKiD.CardSuits.Hearts));
            Console.WriteLine(blackJackhand.Score);
            blackJackhand.draw(100, 200);
            blackJackhand.addCard(Factory.makeCard(BLACKJACKiD.CardFace.Ten, BLACKJACKiD.CardSuits.Hearts));
            Console.WriteLine(blackJackhand.Score);

        }       
    }
}