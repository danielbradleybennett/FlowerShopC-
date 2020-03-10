using System;

namespace FlowerShop
{
  public class DeathThorn : IMothersDay
  {
    public string Color { get; set; }
    public string Name { get; set; }
    public string Thorny { get; set; }
    public string Fragrant { get; set; }
    public string WaterSchedule { get; set; }

    public string Location { get; set; }

    public int Cost { get; set; }

    public double StemLength { get; set; }

    public double PedalCount { get; set; }

    public override string ToString()
    {
      return $"fanciful {Color} with a sweet {Fragrant} that {Cost}.";
    }
  }
}