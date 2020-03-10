using System;
using System.Collections.Generic;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose redRose = new Rose();

            redRose.Color = "red";
            redRose.Name = "Jack";
            redRose.Thorny = "really thorny";
            redRose.Fragrant = "heavenly";
            redRose.WaterSchedule = "once a day";
            redRose.Cost = 45;

            DeathThorn blackDeathThorn = new DeathThorn();
            blackDeathThorn.Name = "Happy";
            blackDeathThorn.Cost = 100;
            blackDeathThorn.PedalCount = 5;
            blackDeathThorn.StemLength = 20;
            blackDeathThorn.Location = "Skyrim";

            PoisonBloom pinkPoisonBloom = new PoisonBloom();

            Tulip yellowTulip = new Tulip();

            FlowerShop myFlowerShop = new FlowerShop();

        }
    }
}