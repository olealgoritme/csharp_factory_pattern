using System;
namespace FactoryPattern
{
    // RoadLogistics (creator) class that implements Logistics
    public class RoadLogistics : Logistics
    {
        public RoadLogistics() {}

        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}