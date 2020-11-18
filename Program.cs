using System;

namespace factory_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello transportation app !");
           
            var sedan = new Sedan();
            Console.WriteLine("{0}", sedan.CreateVehicle());

            var truck = new Truck();
            Console.WriteLine("{0}", truck.CreateVehicle());

            var bus = new Bus();
            Console.WriteLine("{0}", bus.CreateVehicle());
        }
    }
}
