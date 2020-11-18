using System;

public class Sedan: Transportor
{
    public override ICar CreateCar()
    {
        return new SedanObj();
    }
}