using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCost_AdapterPattern
{
    internal interface ITarget
    {
       double CalculateShippingCost(double wt);
    }
}
