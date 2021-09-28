using System;
namespace FactoryPattern
{    
    // Ship class that implements the ITransport interface
    public class Ship : ITransport
    {
        public Ship() {}

        public void Deliver()
        {
            Console.WriteLine("Delivering by sea!");
        }
    }
}
