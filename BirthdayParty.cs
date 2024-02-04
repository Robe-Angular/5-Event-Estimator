using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Event_Estimator
{
    class BirthdayParty:Party
    {
        
        public int CakeSize;        
        private string cakeWritting = "";

        public BirthdayParty(int numberOfPeople, bool fancyDecorations,string cakeWritting)
            : base(numberOfPeople, fancyDecorations){
            CakeWritting = cakeWritting;
        }
        public string CakeWritting
        {
            get { return cakeWritting; }
            set
            {
                int maxLength;
                CalculateCakeSize();
                maxLength = CakeSize == 8 ? 16 : 40;
                /*
                if (value == null)
                {
                    value = "";
                    Console.WriteLine("No more null");
                }
                */
                
                
                if(value.Length > maxLength)
                {
                    MessageBox.Show($"Too many leters for a  {CakeSize} inch cake");
                    /*if (maxLength > cakeWritting.Length)
                        maxLength = this.cakeWritting.Length;*/
                    cakeWritting = cakeWritting.Substring(0, maxLength);
                }
                else
                {
                    cakeWritting = value;
                }

            }
        }
        
        private void CalculateCakeSize()
        {
            CakeSize = NumberOfPeople > 4 ? 16 : 8;
        }
        public override decimal CalculateCost()
        {
            int cakePrice = NumberOfPeople < 5 ? 40 : 75;
            decimal lettersPrice = cakeWritting.Length * 0.25M;
            decimal cakeWithLettersPrice = cakePrice + lettersPrice;
            

            return base.CalculateCost() + cakeWithLettersPrice;
        }
        public override int NumberOfPeople
        {
            get
            {
                return base.NumberOfPeople;
            }
            set
            {
                Console.WriteLine("BithdayNumberPeople");
                base.NumberOfPeople = value;
                CakeWritting = cakeWritting;
            }
        }
    }
}
