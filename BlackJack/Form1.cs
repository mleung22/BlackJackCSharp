using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class blackJackForm : Form
    { 
        
        Deck playingDeck = new Deck();
        List<Card> dealer = new List<Card>();
        List<Card> player = new List<Card>();
        int playerSum = 0;
        int dealerSum = 0;
        int playerDealtCard = 2;
        int dealerDealtCard = 2;
        bool dealerTurn = true;
        
        public blackJackForm()
        {
            InitializeComponent();
            hitButton.Enabled = false;
            stayButton.Enabled = false;
        }

        private void calculatePlayerHand(Card playerCards)
        {
            switch (playerCards.getRank())
            {
                case Ranks.JACK:
                    playerSum += Convert.ToInt32(playerCards.getRank()) - 1;
                    break;
                case Ranks.QUEEN:
                    playerSum += Convert.ToInt32(playerCards.getRank()) - 2;
                    break;
                case Ranks.KING:
                    playerSum += Convert.ToInt32(playerCards.getRank()) - 3;
                    break;
                case Ranks.ACE:
                    playerSum += Convert.ToInt32(playerCards.getRank()) - 3;
                    break;
                default:
                    playerSum += Convert.ToInt32(playerCards.getRank());
                    break;
            } 
        }

        private void calculateDealerHand(Card dealerCards)
        {
            switch (dealerCards.getRank())
            {
                case Ranks.JACK:
                    dealerSum += Convert.ToInt32(dealerCards.getRank()) - 1;
                    break;
                case Ranks.QUEEN:
                    dealerSum += Convert.ToInt32(dealerCards.getRank()) - 2;
                    break;
                case Ranks.KING:
                    dealerSum += Convert.ToInt32(dealerCards.getRank()) - 3;
                    break;
                case Ranks.ACE:
                    dealerSum += Convert.ToInt32(dealerCards.getRank()) - 3;
                    break;
                default:
                    dealerSum += Convert.ToInt32(dealerCards.getRank());
                    break;
            }
        }

        private Boolean isBusted(int sum)
        {
            if (sum > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dealButton_Click(object sender, EventArgs e)
        {

            for (int c = 0; c < 2; c++)
            {
                dealer.Add(playingDeck.deal());
                player.Add(playingDeck.deal());
            }

            dealerListBox.Items.Add(dealer[0]);
            dealerListBox.Items.Add(dealer[1]);

            playerListBox.Items.Add(player[0]);
            playerListBox.Items.Add(player[1]);

            foreach (Card playerHand in player)
            {
                calculatePlayerHand(playerHand);
            }

            foreach (Card dealerHand in dealer)
            {
                calculateDealerHand(dealerHand);
            }
 
            playerSumLabel.Text = playerSum.ToString();
            dealerSumLabel.Text = dealerSum.ToString();
            dealButton.Enabled = false;
            hitButton.Enabled = true;
            stayButton.Enabled = true;
                  
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            dealerListBox.Items.Clear();
            playerListBox.Items.Clear();
            dealer.Clear();
            player.Clear();
            dealerSumLabel.Text = " ";
            playerSumLabel.Text = " ";           
            dealerSum = 0;
            playerSum = 0;
            playerDealtCard = 2;
            dealerDealtCard = 2;
            playingDeck.shuffle();
            dealButton.Enabled = true;          
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            
            player.Add(playingDeck.deal());

            calculatePlayerHand(player[playerDealtCard]);
          
            playerListBox.Items.Add(player[playerDealtCard]);
            playerSumLabel.Text = playerSum.ToString();

            if (isBusted(playerSum))
            {
                MessageBox.Show("You Busted, Dealer Wins!");
                hitButton.Enabled = false;
                stayButton.Enabled = false;
                dealButton.Enabled = false;
            }
            playerDealtCard++;
        }

        private void stayButton_Click(object sender, EventArgs e)
        {
            hitButton.Enabled = false;
            stayButton.Enabled = false;

            while (dealerTurn)
            {
                if (dealerSum <= 17)
                {
                    dealer.Add(playingDeck.deal());
                    calculateDealerHand(dealer[dealerDealtCard]);

                    dealerListBox.Items.Add(dealer[dealerDealtCard]);
                    dealerSumLabel.Text = dealerSum.ToString();
                    dealerDealtCard++;

                    if (isBusted(dealerSum))
                    {
                        MessageBox.Show("Dealer busted!, You Win!");
                        hitButton.Enabled = false;
                        stayButton.Enabled = false;
                        dealButton.Enabled = false;
                    }
                }
                else
                {
                    dealerTurn = false;
                }
            }

            if (!isBusted(playerSum) && playerSum > dealerSum)
            {
                MessageBox.Show("Player Wins!");
            }
            else if (!isBusted(dealerSum) && dealerSum > playerSum)
            {
                MessageBox.Show("Dealer Wins!");
            }
        }

 


    }

    

    
}
