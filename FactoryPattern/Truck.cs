using System;
namespace FactoryPattern
{
    // Truck class that implements the ITransport interface
    public class Truck : ITransport
    {
        public Truck() {}

        public void Deliver()
        {
            Console.WriteLine("Delivering by road!");
        }
    }
}
