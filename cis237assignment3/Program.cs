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

// main class, "the one that executes first and calls everything else"
namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates a new ui class
            UI userInterface = new UI();
            userInterface.mainMenu();   // calls the mainMenu method in the ui class
        }
    }
}
