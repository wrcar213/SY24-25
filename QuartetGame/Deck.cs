using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Quartet
{
    internal class Deck
    {
        List<CarCard> carCards = new List<CarCard>();
        public Deck(List<CarCard> cards)
        {
          this.carCards = cards;
        }
        public void Shuffle()
        {
            Random rand = new Random();
            int n = 0;
            CarCard temp = null;
            for (int i = 0; i < carCards.Count; i++)
            { 
             temp = carCards[i];
                n = rand.Next(carCards.Count);
                carCards[i] = carCards[n];
                carCards[n] = temp;
            }
        }
        public CarCard GetCard(int index) 
        {
            CarCard C = carCards[index];
            carCards.RemoveAt(index);
            return C;
        }
        public override string ToString()
        {
            string retVal = "Deck: \n";
            foreach (CarCard card in carCards)
            { 
            retVal += card.ToString();
            }
            return retVal;
        }
    }
}
