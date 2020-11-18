using System;

public class Bus: Transportor
{
    public override ICar CreateCar()
    {
        return new BusObj();
    }
}
