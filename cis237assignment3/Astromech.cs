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
        //*****************************************
        //*             Backing fields            *
        //*****************************************
        bool _fireExtinguisher;
        bool _toolbox;
        bool _computerConnection;
        bool _arm;

        int _numberShips;
        const decimal costPerShip = 300;
        private decimal _totalCostDecimal;

        //*****************************************
        //*             Constructor               *
        //*****************************************
        public Astromech(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(materialString, modelString, colorString, toolbox, computerConnection, arm)
        {
            _fireExtinguisher = fireExtinguisher;
            _numberShips = numberShips;
            _computerConnection = computerConnection;
            _arm = arm;
            _toolbox = toolbox;

            CalculateTotalCost();
        }

        public decimal TotalCost
        {
            get { return _totalCostDecimal; }
            set { _totalCostDecimal = value; }
        }

        //*****************************************
        //*             Methods                   *
        //*****************************************
        public override string ToString()   // override for the ToString method
        {
            return base.ToString();
        }

        public decimal CostOfShips      // calculates the cost for all added ships
        {
            get { return _numberShips * costPerShip; }
        }

        public override void CalculateTotalCost()       // calculates the total cost
        {
           base.CalculateTotalCost();                  // gets the base total cost (withoud added features)
           this._totalCostDecimal = base.totalCostDecimal; // assigns the base total to the current total

            if(_fireExtinguisher)                            // checks to see if a fireextinguisher is added
                this.totalCostDecimal += 200;               // adds 200 for the fire extinguisher

            this.totalCostDecimal += CostOfShips;           // rolls the ship cose into the new total
        }
    }
}
