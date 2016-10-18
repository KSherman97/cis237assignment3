/**
 * Kyle sherman
 * Assignment 3
 * DUE 10/18/2016
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        private int numberLanguages;
        private decimal costPerLanguage = 300;

        public Protocol(string materialString, string modelString, string colorString, int numberOfLanguages) :
            base(materialString, modelString, colorString)
        {
            numberLanguages = numberOfLanguages;
            CalculateTotalCost();
        }

        public decimal CostOfLangauages
        {
            get
            {
                return this.numberLanguages * costPerLanguage;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            this.totalCostDecimal = base.totalCostDecimal;

            totalCostDecimal += CostOfLangauages; 
        }
    }
}
