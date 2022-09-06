using System;
public class PropertyHolder
{
    private int someProperty = 0;
 
    public PropertyHolder() { }
 
    public PropertyHolder(int iVal)
    {
        SomeProperty = iVal;
    }

    public int SomeProperty
    {
        get
       {
            return someProperty;
        }
        set
       {
            someProperty = value;
        }
    }
 
    public void setPropValue(int iVal)
    {
        SomeProperty = iVal;
    }
}
public class propertyTester
{
    Main(string[] args)
    {
     PropertyHolder propHold = new PropertyHolder();
     Console.WriteLine(propHold.SomeProperty);
     propHold.SomeProperty = 5;
     Console.WriteLine(propHold.SomeProperty);
     propHold.setPropValue(15);
     Console.WriteLine(propHold.SomeProperty);

     propHold = new PropertyHolder(120);
     Console.WriteLine(propHold.SomeProperty);
   PropertyHolder propHold_1 = new PropertyHolder 
     {
        SomeProperty = 152,
        MoreProperty = 92
     };
 
     Console.WriteLine(propHold_1.SomeProperty);
     Console.WriteLine(propHold_1.MoreProperty);
 
     propHold = new PropertyHolder 
     {
        SomeProperty = 152,
        MoreProperty = 92
     };
 
     Console.WriteLine(propHold.SomeProperty);
     Console.WriteLine(propHold.MoreProperty);
 
     return 0;
    }