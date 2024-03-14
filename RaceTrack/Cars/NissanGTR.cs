using System;
using Microsoft.VisualBasic;

namespace RaceTrack.RaceTrack.Cars;

public class NissanGTR : RaceCar
{
    public NissanGTR()
    {
        Name = "Nissan GTR";
        TopSpeed = 200;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"Why'd you pay so much for your {Strings.Split(Name)[0]}? Because it's {Strings.Split(Name)[1]}.");
    }

    override 
    public void Brake()
    {
        Console.WriteLine("SKRRRRRRRT");
    }
}