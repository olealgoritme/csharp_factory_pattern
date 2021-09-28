using System;
namespace FactoryPattern
{
    public abstract class Logistics
    {
       public abstract ITransport CreateTransport();
    }
}