using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        bool fireExtinguisher;
        int numberShips;
        const decimal costPerShip = 300;

        public Astromech(string materialString, string modelString, string colorString, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(materialString, modelString, colorString, toolbox, computerConnection, arm)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void CalculateTotalCost()
        {

        }
    }
}
