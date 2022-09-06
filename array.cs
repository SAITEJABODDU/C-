using System;
class MultiArrayProgram 
{
    public static void Main() 
    {
        int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
        foreach (int i in numbers)
        {
            Console.Write("{0} ", i);
        }
        
 
        Console.WriteLine("");
 
        int[] numbers2D = new int[3, 2] { { 9, 99 } , { 3, 33 }, { 5, 55 } };
        foreach (int i in numbers2D)
        {
            Console.Write("{0} ", i);
        }
 
        Console.WriteLine("");
 
        // Or use the short form: 
        int[] numbers2D_1 = { { 9, 99 }, { 3, 33 }, { 5, 55 } }; 
        foreach (int i in numbers2D_1)
        {
            Console.Write("{0} ", i);
        }
 
        Console.WriteLine("");
        
    }
}