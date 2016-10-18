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
    class Utility : Droid
    {
        bool toolbox;
        bool computerConnection;
        bool arm;

        public Utility(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm) : base( materialString,  modelString,  colorString)
        {
            toolbox = toolbox;
            computerConnection = computerConnection;
            arm = arm;

            CalculateTotalCost();
        }

        public override string ToString()
        {
 	         return base.ToString();
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            this.totalCostDecimal = base.totalCostDecimal;
            if (toolbox)
                this.totalCostDecimal += 100;

            if (computerConnection)
                this.totalCostDecimal += 850;

            if (arm)
                this.totalCostDecimal += 600;
        }
    }
}
