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
            droidArray[index] = new Protocol(materialString, modelString, colorString, numberOfLanguages); // add a new droid of type protocol and pass the required variables
            index++;    // increment the index
        }

        // addDroid method 2 - used to add utility droid to the array
        public void addDroid(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm)
        {
            droidArray[index] = new Utility(materialString, modelString, colorString, toolbox, computerConnection, arm);// add a new droid of type utility and pass the required variables
            index++;    // increment the index
        }

        // addDroid method 3 - used to add Janitor droid to the array
        public void addDroid(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
        {
            droidArray[index] = new Janitor(materialString, modelString, colorString, toolbox, computerConnection, arm, trashCompactor, vacuum);// add a new droid of type janitor and pass the required variables
            index++;    // increment the index
        }

        // addDroid method 4 - used to add Astromech droid to the array
        public void addDroid(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
        {
            droidArray[index] = new Astromech(materialString, modelString, colorString, toolbox, computerConnection, arm, fireExtinguisher, numberShips);// add a new droid of type astromech and pass the required variables
            index++;    // increment the index
        }

        // this method will collect all of the droid data and output it based on the type of droid
        public string outputDroidArray()
        {
            string allOutPut = "";  // creates a new blank string
            foreach (Droid droid in droidArray) // foreach loop for each droid in the array
            {
                if (droid != null)   // checks to see if the list is full or not 
                {
                    // for the type checking I opted to use the "is" expression because it looked the cleanest
                    // reference:   http://stackoverflow.com/questions/983030/type-checking-typeof-gettype-or-is
                    //              http://net-informations.com/q/faq/type.html
                    //              https://msdn.microsoft.com/en-us/library/scekt9xw.aspx

                    // is the droid of type Protocol?
                    if (droid is Protocol)
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((Protocol)droid).ToString() + " " +
                            ((Protocol)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                    // is the droid of type Utility?
                    else if (droid is Utility)
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((Utility)droid).ToString() + " " +
                            ((Utility)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                    // is the droid of type Janitor?
                    else if (droid is Janitor)
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((Janitor)droid).ToString() + " " +
                            ((Janitor)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                    // is the droid of type Astromech?
                    else if (droid is Astromech)
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((Astromech)droid).ToString() + " " +
                            ((Astromech)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                }
            }
            if (allOutPut == null || allOutPut == string.Empty) // checks to see if there is anything in the alloutput string
                allOutPut = "There are no droids to show";      // if it is empty or null then let the user know

            return allOutPut;   // return the alloutput final results
        }
    }
}