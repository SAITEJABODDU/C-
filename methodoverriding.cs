using System;
public abstract class BaseC  
{  
    public virtual void Begin(string msg)   
    {  
        Console.WriteLine("Base: " + msg);  
    }  

    public virtual void End()  
    {  
        Console.WriteLine("Completed - Base");  
    }  
}  
 
public class DerivedC : BaseC  
{  
    public override void Begin(string msg)   
    {  
        Console.WriteLine("Derived : " + msg);  
    }  

    public new void End() 
    {  
    //base.Begin("Calling Base: ");
        Console.WriteLine("Completed - Derived"); 
    }  
}
 

public class TestOverrideShadow  
{  
  public static void Main()
  {
      BaseC overrides = new DerivedC(); // overriding Base, hence only methods that are Derived are available 
    DerivedC shadows = new DerivedC(); // hiding, hence both the methods are available from Base and Derived

        overrides.Begin("Begin Test ");  
        overrides.End();  
 
        shadows.Begin("Begin Test ");  
        shadows.End();  
  }
} 