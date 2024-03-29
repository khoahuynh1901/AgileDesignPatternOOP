using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCost_AdapterPattern
{
    internal class Adapter : ITarget
    {
        public double CalculateShippingCost(double wt)
        {
            CanadaPost shipper = new CanadaPost();
            return shipper.PostalCost(wt);
        }

    }
}
