using System;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla()
            {
                MainColor = "Burgundy"
            };
            Cessna mx410 = new Cessna();
            Ram coalRoller = new Ram()
            {
                MainColor = "Neon Blue"
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            coalRoller.Drive();
            coalRoller.Turn("left");
            coalRoller.Stop();
        }
    }
}
