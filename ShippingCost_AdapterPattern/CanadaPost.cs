using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Wasm;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCost_AdapterPattern
{
    internal class CanadaPost
    {
        public double PostalCost(double packageWeight)
        {
            double shipcost;
            if (packageWeight <= 5)
            {
                shipcost = 3.50;
            }
            else if (packageWeight <= 10)
            {
                shipcost = 5.00;
            }
            else if (packageWeight <= 15)
            {
                shipcost = 7.50;
            } 
            else if (packageWeight < 20) 
            {
                shipcost = 10.00;

            }
            else
            {
                shipcost = 15.00;
            }
            Console.Write("Your total shipping cost is: ");
            return shipcost;
            
        }
    }
}
