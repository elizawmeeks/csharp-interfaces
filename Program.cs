using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();
}

public interface IFly
{
    int Wings { get; set; }
    double MaxAirSpeed { get; set; }
    void Fly();
}

public interface IGround
{
    double MaxLandSpeed { get; set; }
    void Drive();
}

public interface IAquatic
{
    double MaxWaterSpeed { get; set; }
    void Drive();
}

public class JetSki : IVehicle, IAquatic
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Houseboat : IVehicle, IAquatic
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The Houseboat slowly floats around, bringing families to new places");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IVehicle, IGround
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxLandSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Van : IVehicle, IGround
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxLandSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The van races to its destination to get screaming children out of confined spaces.");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IVehicle, IFly
{
    public int Wings { get; set; }
    public double MaxAirSpeed { get; set; }
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Helicopter : IVehicle, IFly
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public int Wings { get; set; }
    public double MaxAirSpeed { get; set; }

    public void Fly()
    {
        Console.WriteLine("The helicopter chops through teh skies.");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}


public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        Cessna cess172 = new Cessna();
        Cessna cessC34  = new Cessna();
        Helicopter Chinook = new Helicopter();
        Helicopter Iriqois = new Helicopter();

        List<IFly> flying = new List<IFly>(){
            cess172, cessC34, Chinook, Iriqois
        };

        // With a single `foreach`, have each vehicle Fly()
        foreach (IFly thing in flying){
            thing.Fly();
        }

        // Build a collection of all vehicles that operate on roads
        Van Odyssey = new Van();
        Van Sienna = new Van();
        Motorcycle Yellow = new Motorcycle();
        Motorcycle Green = new Motorcycle();

        List<IGround> ground = new List<IGround>(){
            Odyssey, Sienna, Yellow, Green
        };

        // With a single `foreach`, have each road vehicle Drive()
        foreach (IGround thing in ground){
            thing.Drive();
        }

        // Build a collection of all vehicles that operate on water
        Houseboat Mine = new Houseboat();
        Houseboat Yours = new Houseboat();
        JetSki purple = new JetSki();
        JetSki green = new JetSki();

        List<IAquatic> swim = new List<IAquatic>(){
            Mine, Yours, purple, green
        };

        // With a single `foreach`, have each water vehicle Drive()
        foreach (IAquatic thing in swim){
            thing.Drive();
        }
    }

}
