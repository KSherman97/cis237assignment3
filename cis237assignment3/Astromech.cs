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
    // inherits from the utility class
    class Astromech : Utility
    {
        bool fireExtinguisher;
        int numberShips;
        const decimal costPerShip = 300;
        private decimal totalCostDecimal;

        public Astromech(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(materialString, modelString, colorString, toolbox, computerConnection, arm)
        {
            fireExtinguisher = fireExtinguisher;
            numberShips = numberShips;

            CalculateTotalCost();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public decimal CostOfShips
        {
            get { return numberShips * costPerShip; }
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            this.totalCostDecimal = base.totalCostDecimal;

            if(fireExtinguisher)
                this.totalCostDecimal += 200;

            this.totalCostDecimal += CostOfShips;
        }
    }
}
