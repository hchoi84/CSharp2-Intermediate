using System;

namespace Exercise05_Workflow
{
  public class Sorcerror : ITrainUnit
  {
    public void Execute()
    {
      MakeStaff();
      ImbueStaff();
      CraftOutfit();
      Ready();
    }

    private void MakeStaff()
    {
      Console.WriteLine("Making Staff");
    }

    private void ImbueStaff()
    {
      Console.WriteLine("Imbuing Staff");
    }

    private void CraftOutfit()
    {
      Console.WriteLine("Crafting Outfit");
    }

    private void Ready()
    {
      Console.WriteLine("Sorcerror Ready");
    }
  }
}
