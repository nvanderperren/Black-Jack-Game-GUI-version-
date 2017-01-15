﻿using System;
using Newtonsoft.Json;

namespace BlackJackGameGUI.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BlackJackCard : Card
    {
        #region Properties

        [JsonProperty]
        public bool FaceUp { get; set; }
        public int Value => FaceUp ? Math.Min(10, (int) FaceValue) : 0;

        #endregion

        #region Constructors
        public BlackJackCard(Suit suit, FaceValue faceValue) : base(suit, faceValue)
        {
            FaceUp = false;
        }
        #endregion

        #region Methods
        public void TurnCard()
        {
            FaceUp = !FaceUp;
        } 
        #endregion
    }
}
