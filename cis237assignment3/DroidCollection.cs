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
    class DroidCollection
    {
        IDroid[] droidArray = new Droid[100];   // creates a new idroid array of the class droid

        int index = 0;                          // creates a new index variable

        public DroidCollection() { index = 0; } // blank constructor that ensures the index is set to zero

        // addDroid method 1 - used to add protocol droid to the array
        public void addDroid(string materialString, string modelString, string colorString, int numberOfLanguages)
        {
            droidArray[index] = new Protocol(materialString, modelString, colorString, numberOfLanguages);
            index++;
        }

        // addDroid method 2 - used to add utility droid to the array
        public void addDroid(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm)
        {
            droidArray[index] = new Utility(materialString, modelString, colorString, toolbox, computerConnection, arm);
            index++;
        }

        // addDroid method 3 - used to add Janitor droid to the array
        public void addDroid(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
        {
            droidArray[index] = new Janitor(materialString, modelString, colorString, toolbox, computerConnection, arm, trashCompactor, vacuum);
            index++;
        }

        // addDroid method 4 - used to add Astromech droid to the array
        public void addDroid(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
        {
            droidArray[index] = new Astromech(materialString, modelString, colorString, toolbox, computerConnection, arm, fireExtinguisher, numberShips);
            index++;
        }

        // this method will collect all of the droid data and output it based on the type of droid
        public string outputDroidArray()
        {
            string allOutPut = "";  // creates a new blank string
            foreach (Droid droid in droidArray) // foreach loop for each droid in the array
            {
                if(droid != null)   // checks to see if the list is full or not 
                {
                    // is the droid of type Protocol?
                    if(droid.GetType() == typeof(Protocol))
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((Protocol)droid).ToString() + " " + 
                            ((Protocol)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                    // is the droid of type Utility?
                    else if (droid.GetType() == typeof(Utility))
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((Utility)droid).ToString() + " " +
                            ((Utility)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                    // is the droid of type Janitor?
                    else if (droid.GetType() == typeof(Janitor))
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((Janitor)droid).ToString() + " " +
                            ((Janitor)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                    // is the droid of type Astromech?
                    else if (droid.GetType() == typeof(Astromech))
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((Astromech)droid).ToString() + " " +
                            ((Astromech)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                }
                else // if the array is empty then output that there is nothing
                {
                    allOutPut = "There is no droids in the array";
                }
            }
            return allOutPut;   // return the alloutput final results
        }
    }
}
