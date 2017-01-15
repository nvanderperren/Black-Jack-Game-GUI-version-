

using Newtonsoft.Json;

namespace BlackJackGameGUI.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Card
    {
        
        #region Properties
        [JsonProperty]
        public FaceValue FaceValue { get; set; }
        [JsonProperty]
        public Suit Suit { get; set; }
        #endregion

        #region Constructors
        public Card(Suit suit, FaceValue faceValue)
        {
            Suit = suit;
            FaceValue = faceValue;
        } 
        #endregion
    }
}
