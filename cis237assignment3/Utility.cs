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
    class Utility : Droid
    {

        //*****************************************
        //*             Backing fields            *
        //*****************************************
        bool toolbox;
        bool computerConnection;
        bool arm;

        //*****************************************
        //*             Constructor               *
        //*****************************************
        public Utility(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm) : base( materialString,  modelString,  colorString)
        {
            toolbox = toolbox;
            computerConnection = computerConnection;
            arm = arm;

            CalculateTotalCost();
        }

        //*****************************************
        //*             Methods                   *
        //*****************************************
        public override string ToString() // override for the ToString method
        {
 	         return base.ToString();
        }

        public override void CalculateTotalCost() // calculates the total cost for the droid
        {
            base.CalculateTotalCost();                  // gets the base total cost (withoud added features)
            this.totalCostDecimal = base.totalCostDecimal; // assigns the base total to the current total

            if (toolbox)                                    // checks to see if a toolbox is added
                this.totalCostDecimal += 100;               // adds the corrosponding price to the total

            if (computerConnection)                         // checks to see if a computer connection is added
                this.totalCostDecimal += 850;               // adds 850 for the computer connection

            if (arm)                                        // checks to see if an arm has been added
                this.totalCostDecimal += 600;               // adds 600 for the arm
        }
    }
}
