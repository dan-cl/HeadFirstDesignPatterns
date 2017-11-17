using System;

namespace MiniDuckSimulator
{
  public class Duck {
      
      public IFlybehavior flyBehavior { get; set; }
      public IQuackBehavior quackBehavior { get; set; }

      public Duck(){
      }

      public virtual void display(){
      }

      public void setFlyBehavior(IFlybehavior fb){
        flyBehavior = fb;
      }

      public void performFly() {
        flyBehavior.fly();
      }

      public void setQuackBehavior(IQuackBehavior qb){
        quackBehavior = qb;
      }

      public void performQuack(){
        quackBehavior.quack();
      }

      public void swim() {
        Console.WriteLine("All ducks float, even decoys!");
      }
  }
}
