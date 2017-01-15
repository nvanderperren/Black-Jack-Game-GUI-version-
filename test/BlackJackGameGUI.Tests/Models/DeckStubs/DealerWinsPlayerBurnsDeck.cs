﻿using System.Collections.Generic;
using BlackJackGameGUI.Models;

namespace BlackJackGameGUI.Tests.Models.DeckStubs {
    class DealerWinsPlayerBurnsDeck : Deck {

        public DealerWinsPlayerBurnsDeck() {
            _cards = new List<BlackJackCard>
            {
                //dealer
                new BlackJackCard(Suit.Clubs, FaceValue.Seven),
                new BlackJackCard(Suit.Clubs, FaceValue.Seven),
            
                //player
                new BlackJackCard(Suit.Clubs, FaceValue.Nine),
                new BlackJackCard(Suit.Clubs, FaceValue.Nine),

                //player
                new BlackJackCard(Suit.Clubs, FaceValue.Ten),
            };
        }
    }
}
