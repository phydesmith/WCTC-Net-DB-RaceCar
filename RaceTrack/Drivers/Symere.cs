using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers;

public class Symere : Driver
{
    public Symere(RaceCar car) : base(car)
    {
        Name = "Symere";
        SkillLevel = 20;
    }

    public override void Drive()
    {
        Car.Accelerate(SkillLevel);
    }
    
}