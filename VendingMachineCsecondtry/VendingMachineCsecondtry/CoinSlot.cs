using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineCsecondtry
{
    internal class CoinSlot
    {
        private double totalAmount;

        public CoinSlot()
        {
            totalAmount = 0.0;
        }

        public void InsertCoin(string coin)
        {
            switch (coin.ToLower())
            {
                case "nickel":
                    totalAmount += 0.05;
                    break;
                case "dime":
                    totalAmount += 0.10;
                    break;
                case "quarter":
                    totalAmount += 0.25;
                    break;
                case "dollar":
                    totalAmount += 1.00;
                    break;
                default:
                    throw new ArgumentException("Invalid coin type.");
            }
        }

        public double Total()
        {
            return totalAmount;
        }

        public void CoinReturn()
        {
            totalAmount = 0.0;
        }
    }
}
