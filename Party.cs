using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Event_Estimator
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        private bool fancyDecorations;
        public decimal CostOfDecorations;
        public virtual int NumberOfPeople{
            get
            {
                return numberOfPeople;
            }
            set
            {
                Console.WriteLine("PartyNumberPeople");
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }
        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            NumberOfPeople = numberOfPeople;
            CalculateCostOfDecorations(fancyDecorations);
        }        
        public virtual decimal CalculateCost()
        {
            decimal cost = ( CostOfFoodPerPerson * NumberOfPeople + CostOfDecorations);

            if(NumberOfPeople > 12)
            {
                cost += 100M;
            }
            return cost;
        }

        public void CalculateCostOfDecorations(bool isFancy)
        {
            fancyDecorations = isFancy;
            decimal costPerPerson;
            int decoratingFee;
            costPerPerson = isFancy ? 15.0M : 7.5M;
            decoratingFee = isFancy ? 50 : 30;
            CostOfDecorations = NumberOfPeople * costPerPerson + decoratingFee;
        }

    }
}
