using System;
namespace FactoryPattern
{
    // AirLogistics (creator) class that implements Logistics
    public class AirLogistics : Logistics
    {
        public AirLogistics() {}

        public override ITransport CreateTransport()
        {
            return new Plane();
        }
    }
}