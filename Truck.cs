using System;

public class Truck: Transportor
{
    public override ICar CreateCar()
    {
        return new TruckObj();
    }
}