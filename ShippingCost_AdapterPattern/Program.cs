using System;
using System.Numerics;

namespace ShippingCost_AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in Pounds");
            int weight = Convert.ToInt32(Console.ReadLine());
            ITarget adapter = new Adapter();
            Vendor vd = new Vendor(adapter);
            double shippingCost = vd.CalculateShippingCost(weight);
            Console.WriteLine(shippingCost);
        }
    }
}
