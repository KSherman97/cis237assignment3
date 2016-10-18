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
