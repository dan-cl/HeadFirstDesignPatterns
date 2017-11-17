using System;

namespace MiniDuckSimulator
{
  public class FlyNoWay : IFlybehavior {
    public void fly () {
      Console.WriteLine("I can't fly");
    }
  }
}