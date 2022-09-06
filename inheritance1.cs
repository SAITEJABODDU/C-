using System;
 
public abstract class BaseC  
{  
    public void Method1(string msg)
    {  
        Console.WriteLine(msg); 
    }  

    public abstract void MethodAbs();
 
    public virtual void MethodImpl(string msg) 
    {  
        Console.WriteLine("From Base: " + msg);
    }  
}  
 
public class TestDerived : BaseC 
{  
  public static void Main()
  {
    TestDerived obj = new TestDerived();
    obj.Method1("Message 1");
    obj.MethodAbs();
    obj.MethodImpl("Implemented by overriding");
  }

  public override void MethodAbs()
  {
    Console.WriteLine("implementing abstract method");
  }
 
  public override void MethodImpl(string msg)   
  {  
      Console.WriteLine("From Child: " + msg);  
  }  
 
}