using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    class Program
    {
        static void Main()
        {
            // Create list of different transportation types
            List<ITransport> transportationList = new();
            transportationList.Add(new RoadLogistics().CreateTransport());
            transportationList.Add(new SeaLogistics().CreateTransport());
            transportationList.Add(new AirLogistics().CreateTransport());

            // Traverse transportation list with deliveries
            foreach (var transport in transportationList)
            {
                transport.Deliver();
            }

        }
    }
}
