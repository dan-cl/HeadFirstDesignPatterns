using System;

namespace MiniDuckSimulator
{
  public class Squeak : IQuackBehavior {
    public void quack() {
      Console.WriteLine("Squeak");
    }
  }
}