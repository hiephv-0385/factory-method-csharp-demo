using System;

public class BusCreator: Transportor
{
    public override ICar CreateCar()
    {
        return new BusObj();
    }
}
