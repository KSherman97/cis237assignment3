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


// droid interface class
// creates the variables that must exist in the child classes
namespace cis237assignment3
{
    interface IDroid
    {
        void CalculateTotalCost();   // total cost void method

        decimal totalCostDecimal { get; set; }  // total cost decimal
    }
}