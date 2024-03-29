using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCost_AdapterPattern
{
    internal class Vendor


    {
        private ITarget _shippingAdapter;

        public Vendor(ITarget shippingAdapter)
        {
            _shippingAdapter = shippingAdapter;
        }

        public double CalculateShippingCost(double weight)
        {
            return _shippingAdapter.CalculateShippingCost(weight);
        }
    }
}
