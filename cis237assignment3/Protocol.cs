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
    // inherits from the droid class
    class Protocol : Droid
    {
        //*****************************************
        //*             Backing fields            *
        //*****************************************
        private int _numberLanguages;
        private decimal _totalCostDecimal;
        private decimal costPerLanguage = 300;

        //*****************************************
        //*             Constructor               *
        //*****************************************
        public Protocol(string materialString, string modelString, string colorString, int numberOfLanguages) :
            base(materialString, modelString, colorString)
        {
            _numberLanguages = numberOfLanguages;
            CalculateTotalCost();
        }

        //*****************************************
        //*             Properties                *
        //*****************************************
        public decimal CostOfLangauages
        {
            get
            {
                return this._numberLanguages * costPerLanguage;
            }
        }

        public decimal TotalCost
        {
            get { return _totalCostDecimal; }
            set { _totalCostDecimal = value; }
        }


        //*****************************************
        //*             Methods                   *
        //*****************************************
        public override string ToString()   // tostring method override
        {
            return base.ToString();
        }

        public override void CalculateTotalCost()           // calculates the total cost for the droid
        {
            base.CalculateTotalCost();                  // gets the base total cost (withoud added features)
            this._totalCostDecimal = base.totalCostDecimal; // assigns the base total to the current total

            _totalCostDecimal += CostOfLangauages;           // rolls the cost of the number of languages into the total
        }
    }
}
