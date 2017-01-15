﻿using BlackJackGameGUI.Models;
using Xunit;

namespace BlackJackGameGUI.Tests.Models
{

    public class CardTest
    {
         [Fact]
        public void NewCardIsCreatedCorrectly()
        {
            Card card = new Card(Suit.Hearts, FaceValue.Ace);
            Assert.Equal(Suit.Hearts, card.Suit);
            Assert.Equal(FaceValue.Ace, card.FaceValue);
        }
    }
}
