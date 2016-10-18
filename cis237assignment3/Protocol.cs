using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        int numberLanguages;
        const decimal costPerLanguage = 300;

        public Protocol(string materialString, string modelString, string colorString, int numberOfLanguages) :
            base(materialString, modelString, colorString)
        {
            numberLanguages = numberOfLanguages;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        override void CalculateTotalCost()
        {

        }
    }
}
