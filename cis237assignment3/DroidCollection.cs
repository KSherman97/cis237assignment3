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
        IDroid[] droidArray = new Droid[100];

        int index = 0;

        public DroidCollection() { index = 0; }

        public void addDroid(string materialString, string modelString, string colorString, int numberOfLanguages)
        {
            droidArray[index] = new Protocol(materialString, modelString, colorString, numberOfLanguages);
            index++;
        }

        public void addDroid(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm)
        {
            droidArray[index] = new Utility(materialString, modelString, colorString, toolbox, computerConnection, arm);
            index++;
        }
        public void addDroid(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
        {
            droidArray[index] = new Janitor(materialString, modelString, colorString, toolbox, computerConnection, arm, trashCompactor, vacuum);
            index++;
        }

        public void addDroid(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
        {
            droidArray[index] = new Astromech(materialString, modelString, colorString, toolbox, computerConnection, arm, fireExtinguisher, numberShips);
            index++;
        }

        public string outputDroidArray()
        {
            string allOutPut = "";
            foreach (Droid droid in droidArray)
            {
                if(droid != null)
                {
                    if(droid.GetType() == typeof(Protocol))
                    {
                        allOutPut += ((Protocol)droid).ToString() + " " + 
                            ((Protocol)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                    else if (droid.GetType() == typeof(Utility))
                    {
                        allOutPut += ((Utility)droid).ToString() + " " +
                            ((Utility)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                    else if (droid.GetType() == typeof(Janitor))
                    {
                        allOutPut += ((Janitor)droid).ToString() + " " +
                            ((Janitor)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                    else if (droid.GetType() == typeof(Astromech))
                    {
                        allOutPut += ((Astromech)droid).ToString() + " " +
                            ((Astromech)droid).totalCostDecimal.ToString("c") + Environment.NewLine;
                    }
                }
            }
            return allOutPut;
        }
    }
}
