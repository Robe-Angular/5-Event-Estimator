using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _5_Event_Estimator
{
    class DinnerParty:Party
    {
        
        public decimal CostOfBeveragesPerPerson;
        

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
            : base(numberOfPeople, fancyDecorations){
            SetHealthyOptions(healthyOption);
        }
        public void SetHealthyOptions(bool isHealthy)
        {
            CostOfBeveragesPerPerson = isHealthy ? 5 : 20;             
        }
        
        
        public decimal CalculateCost(bool isHealthy)
        {
            decimal coefficcientIfHealty = isHealthy ? 0.95M : 1;
            Console.WriteLine(NumberOfPeople);
            decimal cost = ( base.CalculateCost() + CostOfBeveragesPerPerson * NumberOfPeople) * coefficcientIfHealty;
            return cost;
        }

        public void SetPartyOptions(int people)
        {
            NumberOfPeople = people;
        }
        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }

    }

}
