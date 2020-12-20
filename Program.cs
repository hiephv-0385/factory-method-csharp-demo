using System;

namespace factory_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello transportation app !");
           
            var truck = new TruckCreator();
            Console.WriteLine("{0}", truck.CreateVehicle());

            var bus = new BusCreator();
            Console.WriteLine("{0}", bus.CreateVehicle());
        }
    }
}
