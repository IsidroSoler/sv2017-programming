/*
Create a C# program to display the "text mark" corresponding to a certain 
"numerical mark", using the following equivalence:

9,10 = Sobresaliente
7,8 = Notable
6 = Bien
5 = Aprobado
0-4 = Suspenso

Your program must ask the user for a numerical mark and display the 
corresponding text mark.
*/

using System;
public class Marks4
{
    public static void Main()
    {
        int mark;
        
        Console.WriteLine("Enter the mark");
        mark = Convert.ToInt32(Console.ReadLine());
        
        switch (mark)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
                Console.WriteLine("Suspenso");
                break;
            case 5:
                Console.WriteLine("Suficiente");
                break;
            case 6:
                Console.WriteLine("Bien");
                break;
            case 7:
            case 8:
                Console.WriteLine("Notable");
                break;
            case 9:
                Console.WriteLine("Casi perfecto");
                goto case 10;
            case 10:
                Console.WriteLine("Sobresaliente");
                break;
            default:
                Console.WriteLine("???");
                break;
        }
    }
}
