  using System;

namespace MiniDuckSimulator
{
  public class FlyWithWings : IFlybehavior {
    public void fly() {
      Console.WriteLine("I'm flying!!");
    }
  }
}