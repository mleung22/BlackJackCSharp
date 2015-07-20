using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        List<Card> myDeck = new List<Card>();
        private int topCard;
        public static int DECK_LIMIT = 52;
        Random r = new Random();
        
        public Deck()
        {
            topCard = 0;
            
            foreach (Suits s in Enum.GetValues(typeof(Suits)))
            {
                foreach (Ranks r in Enum.GetValues(typeof(Ranks)))
                {
                    myDeck.Add(new Card(s,r));
                    
                }
            }
            
        }

        public void shuffle()
        {

            int index;
  
            for (int i = 0; i < DECK_LIMIT; i++)
            {
                index = (int) (DECK_LIMIT * r.NextDouble());
                
                Card tmp = myDeck[i];
                myDeck[i] = myDeck[index];
                myDeck[index] = tmp;
            }

            topCard = 0;
        }

        public Card deal()
        {
            if (topCard < DECK_LIMIT)
            {
                
                return myDeck.ElementAt(topCard++);
                
            }
            else
            {
                Console.WriteLine("Deck is out of Cards");
                return null;
            }
            
        }


        public override String ToString()
        {
            string cards = " ";
            foreach (Card c in myDeck)
            {
                cards += c.ToString();
            }
            return "Deck: " + cards;
        }
    }
}
