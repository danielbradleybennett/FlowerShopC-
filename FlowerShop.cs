using System;
using System.Collections.Generic;

namespace FlowerShop
{

  public class FlowerShop

  {
    public List<PoisonBloom> PoisonBlooms = new List<PoisonBloom>();

    public List<Rose> Roses = new List<Rose>();

    public List<Tulip> Tulips = new List<Tulip>();

    public List<DeathThorn> DeathThorns = new List<DeathThorn>();

    public List<IMothersDay> MakeMotherDayArrangement()
    {
      List<IMothersDay> Arrangement = new List<IMothersDay>();
      Arrangement.Add(new DeathThorn());
      Arrangement.Add(new DeathThorn());
      Arrangement.Add(new DeathThorn());
      Arrangement.Add(new PoisonBloom());
      Arrangement.Add(new PoisonBloom());

      return Arrangement;
    }

    public List<IBirthday> MakeBirthdayArrangement()
    {

      List<IBirthday> BdayArrangement = new List<IBirthday>();
      BdayArrangement.Add(new Rose());
      BdayArrangement.Add(new Rose());
      BdayArrangement.Add(new Rose());
      BdayArrangement.Add(new Tulip());
      BdayArrangement.Add(new Tulip());

      return BdayArrangement;

    }

  }

}