using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        private Suits suits;
        private Ranks ranks;

        public Card(Suits suits, Ranks ranks)
        {
            this.suits = suits;
            this.ranks = ranks;
        }

        public Suits getSuit() 
        {
	    return suits;
	}

	public void setSuit(Suits suit) 
        {
	    this.suits = suit;
	}

	public Ranks getRank() 
	{    
            return ranks;
	}

	public void setRank(Ranks rank) 
	{
            this.ranks = rank;                    
	}

	public override String ToString() 
	{
	    return ranks + " of " + suits;
	}
    }
}
