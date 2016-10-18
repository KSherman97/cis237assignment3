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
    class Janitor: Utility
    {

        //*****************************************
        //*             Backing fields            *
        //*****************************************
        bool _trashCompactor;
        bool _vacuum;
        bool _toolbox;
        bool _computerConnection;
        bool _arm;
        private decimal _totalCostDecimal;

        //*****************************************
        //*             Constructor               *
        //*****************************************
        public Janitor(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base( materialString,  modelString,  colorString,  toolbox,  computerConnection,  arm)
        {
            _trashCompactor = trashCompactor;
            _vacuum = vacuum;
            _toolbox = toolbox;
            _computerConnection = computerConnection;
            _arm = arm;

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

        public override void CalculateTotalCost()   // calculates the total cost for the droid
        {
            base.CalculateTotalCost();                  // gets the base total cost (withoud added features)
            this._totalCostDecimal = base.totalCostDecimal; // assigns the base total to the current total

            if (_toolbox)                                    // checks to see if a toolbox is added
                this._totalCostDecimal += 100;               // adds the corrosponding price to the total

            if (_computerConnection)                         // checks to see if a computer connection is added
                this._totalCostDecimal += 850;               // adds 850 for the computer connection

            if (_arm)                                        // checks to see if an arm has been added
                this._totalCostDecimal += 600;               // adds 600 for the arm

            if (_trashCompactor)                             // checks to see if a trash compactor has been added
                this._totalCostDecimal += 500;               // adds 500 for this feature

            if (_vacuum)                                     // checks to see if a vacuum has been added
                this._totalCostDecimal += 350;               // adds 350 for this feature
        }
    }
}
