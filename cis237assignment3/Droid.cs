using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        // strings
        string _materialString;
        string _modelString;
        string _colorString;

        // decimals
        decimal baseCostDecimal;
        public decimal totalCostDecimal;

        public Droid(string materialString, string modelString, string colorString)
        {
            _materialString = materialString;
            _modelString = modelString;
            _colorString = colorString;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        abstract void CalculateBaseCost();

        abstract virtual void CalculateTotalCost();

    }
}
