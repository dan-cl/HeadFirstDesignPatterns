using System;

namespace MiniDuckSimulator
{
  public class MuteQuack : IQuackBehavior {
    public void quack() {
      Console.WriteLine("<<Silence>>");
    }
  }
}