using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardApp
{
    public class SimCard
    {
        private double balance;

        public SimCard()
        {
        }

        public SimCard(double balance)
        {
            this.balance = balance;
        }

        public double Balance
        {
            get { return balance; }
        }

        public void BuyAirtime(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            else if (amount > 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            balance += amount;
        }
        public void BuyData(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            balance += amount;
        }

        public void Borrow(double amount)
        {
            if (Balance != 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }


            balance += amount;
        }
        public void DeductAirtime(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance -= amount;
        }
        public void TransferAirtimeTo(SimCard OtherSimcard, double amount)
        {
            if (OtherSimcard is null)
            {
                throw new ArgumentNullException(nameof(OtherSimcard));
            }

            DeductAirtime(amount);
            OtherSimcard.BuyAirtime(amount);
        }

        public bool Balance_is_Low()
        {
            if (Balance < 50)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
