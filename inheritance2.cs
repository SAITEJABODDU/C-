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
        Console.WriteLine(msg);  
    }  
}  
 
// Level 2
public abstract class Interim : BaseC
{  
    public void Method2(string msg)   
    {  
        Console.WriteLine(msg);  
    }  

    public abstract void MethodAbs2();
 
    public virtual void MethodImpl2(string msg)   
    {  
        Console.WriteLine(msg);  
    }  
 
  public override void MethodAbs()
  {
    Console.WriteLine("implementing abstract method - in Interim");
  }
 
}
 

// Level 3 with Main method
public class TestDerived : Interim 
{  
  public static void Main()
  {
    TestDerived obj = new TestDerived();
    obj.Method1("Message 1");
    obj.MethodAbs();
    obj.MethodImpl("Implemented by overriding");
 
    obj.Method2("Message 2");
    obj.MethodAbs2();
    obj.MethodImpl2("Implemented by overriding - MethodImpl2");
  }

  public override void MethodAbs2()
  {
    Console.WriteLine("implementing abstract method");
  }
 
  public override void MethodAbs()
  {
    Console.WriteLine("implementing abstract method 1");
  }
 
  public override void MethodImpl(string msg)   
  {  
      Console.WriteLine(msg);
  }  
 
  public override void MethodImpl2(string msg)   
  {  
      Console.WriteLine(msg);
  }  
 
} 