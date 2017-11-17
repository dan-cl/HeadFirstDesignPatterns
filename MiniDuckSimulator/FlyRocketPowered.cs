using System;

namespace MiniDuckSimulator
{
    public class FlyRocketPowered : IFlybehavior {
      public void fly(){
        Console.WriteLine("I'm flying with a rocket!");
      }
    }
}