using System;

namespace GarysGarage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage {get; set;} = 50;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram roars past, choking you on acrid diesel exhaust. RRrrrruuummmbbblee!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram recklessly flies around the corner, turning {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram can't stop! Someone cut the brakes!");
        }
    }
}