using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Event_Estimator
{
    public partial class Form1 : Form
    {
        bool isFancyChecked;
        bool isHealthyChecked;
        int numberPeopleValue;
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        
        public Form1()
        {
            InitializeComponent();
            isFancyChecked = isFancy.Checked;
            dinnerParty = new DinnerParty((int)numberPeople.Value, isHealthy.Checked, isFancy.Checked)
            {
            };
            birthdayParty = new BirthdayParty((int)numericUpDownBirthday.Value, isFancyBirthday.Checked, hopedText.Text)
            {                
            };

            
            DisplayDinnerPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {            
            decimal Cost = dinnerParty.CalculateCost(isHealthy.Checked);
            costLabel.Text = Cost.ToString("c");
        }
        private void DisplayBirthdayPartyCost()
        {
            decimal Cost = birthdayParty.CalculateCost();
            costBirthdayLabel.Text = Cost.ToString("c");
        }
        private void numberPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOptions((int)numberPeople.Value);
            DisplayDinnerPartyCost();
        }

        private void isFancy_CheckedChanged(object sender, EventArgs e)
        {         
            dinnerParty.CalculateCostOfDecorations(isFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void isHealthy_CheckedChanged(object sender, EventArgs e)
        {         
            dinnerParty.SetHealthyOptions(isHealthy.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUpDownBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDownBirthday.Value;
            hopedText.Text = birthdayParty.CakeWritting;
            DisplayBirthdayPartyCost();
        }

        private void isFancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(isFancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void hopedText_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWritting = hopedText.Text;
            hopedText.Text = birthdayParty.CakeWritting;
        }
    }
}
