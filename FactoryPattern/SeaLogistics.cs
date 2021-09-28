using System;
namespace FactoryPattern
{
    // SeaLogistics (creator) class that implements Logistics
    public class SeaLogistics : Logistics
    {
        public SeaLogistics() {}

        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}