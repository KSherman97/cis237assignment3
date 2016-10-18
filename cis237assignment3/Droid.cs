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
    abstract class Droid : IDroid
    {
        // variables
        // strings
        protected string _materialString;
        protected string _modelString;
        protected string _colorString;

        protected decimal materialCost = 0;
        protected decimal modelCost = 0;
        protected decimal colorCost = 0;

        // decimals
        protected decimal _baseCostDecimal;
        private decimal _totalCostDecimal;
        //protected decimal totalCostDecimal;

        public Droid(string modelString, string materialString, string colorString)
        {
            _modelString = modelString;
            _materialString = materialString;
            _colorString = colorString;

            CalculateTotalCost();
        }


        // properties
        public string Model
        {
            get { return _modelString; }
            set { _modelString = value; }
        }
        public string Material
        {
            get { return _materialString; }
            set { _materialString = value; }
        }
        public string Color
        {
            get { return _colorString; }
            set { _colorString = value; }
        }

        public decimal totalCostDecimal
        {
            get {   return _baseCostDecimal;    }
            set {   _baseCostDecimal = value;   }
        }


        // methods
        public override string ToString()
        {
            return "Model: " + Model + " Cost:";
        }

        public virtual decimal CalculateBaseCost()
        {
            _baseCostDecimal = 0;
            materialCost = 0;
            modelCost = 0;
            colorCost = 0;
            calculateModelCost();
            calculateMaterialCost();
            calculateColorCost();
            _baseCostDecimal = materialCost + modelCost + colorCost;
            return _baseCostDecimal;
        }

        public void calculateModelCost()
        {
            if (Model == "protocol")
            {
                modelCost = 100;
            }
            if (Model == "utility")
            {
                modelCost = 250;
            }
            if (Model == "janitor")
            {
                modelCost = 150;
            }
            if (Model == "astromech")
            {
                modelCost = 325;
            }
        }

        public void calculateMaterialCost()
        {
            if (Material == "cerillium")
            {
                materialCost = 200;
            }
            if (Material == "Polyfibe")
            {
                materialCost = 150;
            }
            if (Material == "Tekonite")
            {
                materialCost = 100;
            }
        }

        public void calculateColorCost()
        {
            if (Color == "red")
            {
                colorCost = 200;
            }
            if (Color == "gold")
            {
                colorCost = 500;
            }
            if (Color == "orange")
            {
                colorCost = 150;
            }
        }

        public virtual void CalculateTotalCost()
        {
            totalCostDecimal = CalculateBaseCost();
        }
    }
}
