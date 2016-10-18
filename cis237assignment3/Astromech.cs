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
        bool fireExtinguisher;
        bool toolbox;
        bool computerConnection;
        bool arm;

        int numberShips = 0;
        const decimal costPerShip = 300;
        private decimal totalCostDecimal;

        //*****************************************
        //*             Constructor               *
        //*****************************************
        public Astromech(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(materialString, modelString, colorString, toolbox, computerConnection, arm)
        {
            fireExtinguisher = fireExtinguisher;
            numberShips = numberShips;
            computerConnection = computerConnection;
            arm = arm;
            toolbox = toolbox;

            CalculateTotalCost();
        }

        //*****************************************
        //*             Methods                   *
        //*****************************************
        public override string ToString()   // override for the ToString method
        {
            return base.ToString() + Environment.NewLine;
        }

        public decimal CostOfShips      // calculates the cost for all added ships
        {
            get { return numberShips * costPerShip; }
        }

        public override void CalculateTotalCost()       // calculates the total cost
        {
            base.CalculateTotalCost();                  // gets the base total cost (withoud added features)
            this.totalCostDecimal = base.totalCostDecimal; // assigns the base total to the current total

            if(fireExtinguisher)                            // checks to see if a fireextinguisher is added
                this.totalCostDecimal += 200;               // adds 200 for the fire extinguisher

            if (toolbox)                                    // checks to see if a toolbox is added
                this.totalCostDecimal += 100;               // adds the corrosponding price to the total

            if (computerConnection)                         // checks to see if a computer connection is added
                this.totalCostDecimal += 850;               // adds 850 for the computer connection

            if (arm)                                        // checks to see if an arm has been added
                this.totalCostDecimal += 600;               // adds 600 for the arm


            this.totalCostDecimal += CostOfShips;           // rolls the ship cose into the new total
        }
    }
}
