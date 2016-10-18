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
    class Janitor: Utility
    {
        bool trashCompactor;
        bool vacuum;

        public Janitor(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base( materialString,  modelString,  colorString,  toolbox,  computerConnection,  arm)
        {
            trashCompactor = trashCompactor;
            vacuum = vacuum;

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

            if (trashCompactor)
                this.totalCostDecimal += 500;
            if (vacuum)
                this.totalCostDecimal += 350;
        }
    }
}
