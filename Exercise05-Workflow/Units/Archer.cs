using System;

namespace Exercise05_Workflow
{
  public class Archer : ITrainUnit
  {
    public void Execute()
    {
      MakeBow();
      MakeArrows();
      CraftOutfit();
      Ready();
    }

    private void MakeBow()
    {
      Console.WriteLine("Making Bow");
    }

    private void MakeArrows()
    {
      Console.WriteLine("Making Arrows");
    }

    private void CraftOutfit()
    {
      Console.WriteLine("Crafting Outfit");
    }

    private void Ready()
    {
      Console.WriteLine("Archer Ready");
    }
  }
}
