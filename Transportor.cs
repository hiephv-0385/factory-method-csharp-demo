using System;

public abstract class Transportor: ICar
{
    public abstract ICar CreateCar();

    public string CreateVehicle()
    {
        var car = CreateCar();

        var result = string.Format("Transportor: The '{0}' has been created", car.CreateVehicle());

        return result;
    }
}