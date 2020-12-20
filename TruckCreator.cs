using System;

public class TruckCreator: Transportor
{
    public override ICar CreateCar()
    {
        return new TruckObj();
    }
}