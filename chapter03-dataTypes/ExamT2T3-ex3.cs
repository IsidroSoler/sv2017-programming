// Examen de los temas 2 y 3, ejercicio 3

using System;

public class ex3
{
    public static void Main()
    {
        double num1, num2, num3;
        byte equals;
        
        Console.Write("Enter a number: ");
        num1=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter another number: ");
        num2=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter another number: ");
        num3=Convert.ToDouble(Console.ReadLine());
        
        if(num1 == num2 && num1 == num3)
            equals = 3;
        else if(num1 != num2 && num1 != num3  && num2 != num3)
            equals = 1;
        else
            equals = 2;            
        Console.WriteLine("Equals? " + equals);
            
        equals = num1 == num2 && num1 == num3 ? (byte) 3 :
            num1 != num2 && num1 != num3  && num2 != num3 ? (byte) 1:
            (byte) 2;
        Console.WriteLine("Equals? " + equals);
    }
}
