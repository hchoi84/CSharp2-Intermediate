using System;

namespace Exercise05_Workflow
{
  public class Paladin : ITrainUnit
  {
    public void Execute()
    {
      MakeSword();
      MakeShield();
      CraftArmor();
      Ready();
    }

    private void MakeSword()
    {
      Console.WriteLine("Making Sword");
    }

    private void MakeShield()
    {
      Console.WriteLine("Making Shield");
    }

    private void CraftArmor()
    {
      Console.WriteLine("Crafting Armor");
    }

    private void Ready()
    {
      Console.WriteLine("Paladin Ready");
    }
  }
}
