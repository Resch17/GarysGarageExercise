using System;

namespace GarysGarage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; } = 50;

        public override void Drive()
        {
            Console.WriteLine("Yeeeeeeoooooowwwww!");
        }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }
}