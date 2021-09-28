using System;
namespace FactoryPattern
{
    // Plane class that implements the ITransport interface
    public class Plane : ITransport
    {
        public Plane() {}

        public void Deliver()
        {
            Console.WriteLine("Delivering by air!");
        }
    }
}
