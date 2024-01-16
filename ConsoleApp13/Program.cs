using System;

public class Program
{
    
    public static int secondLastDigitOf(int input1)
    {
       
        input1 = Math.Abs(input1);

        
        if (input1 < 10)
        {
            return -1;
        }
        else
        {
           
            return (input1 / 10) % 10;
        }
    }

    static void Main()
    {
        
        Console.WriteLine(secondLastDigitOf(197));  
        Console.WriteLine(secondLastDigitOf(-197)); 
        Console.WriteLine(secondLastDigitOf(5));    
        Console.WriteLine(secondLastDigitOf(-5));   
    }
}
