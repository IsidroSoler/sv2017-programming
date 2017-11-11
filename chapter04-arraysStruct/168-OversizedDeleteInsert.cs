/*

Expand the exercise of the array with space for 10000 double precision data, 
and include an option to delete data and another to insert data. Display a 
menu which will allow the user to:

1: Add new data (several data, one at a time, until they press Enter).
2: View data (all of them in a row).
3: Delete data (asking the user for the position)
4: Insert data (asking for the position and the new value)
0: Exit

*/

using System;

public class Ex168
{
    public static void Main()
    {
        double[] data = new double[10000];
        int option, count = 0;

        do
        {
            Console.WriteLine("1.-Add data (at the end)");
            Console.WriteLine("2.-Show data");
            Console.WriteLine("3.-Delete data");
            Console.WriteLine("4.-Insert data (any position)");
            Console.WriteLine("0.-Exit");
            Console.WriteLine();

            Console.Write("Option? ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Enter a real number: ");
                    data[count] = Convert.ToDouble(Console.ReadLine());
                    count++;
                    break;
                case 2:
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(data[i] + " ");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Which position to delete? ");
                    int deletePos = Convert.ToInt32(Console.ReadLine());
                    for (int i = deletePos - 1; i < count - 1; i++)
                    {
                        data[i] = data[i + 1];
                    }
                    count--;
                    break;
                case 4:
                    Console.Write("In which position to insert? ");
                    int insertPos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("New data to insert? ");
                    double newData = Convert.ToDouble(Console.ReadLine());
                    for (int i = count; i >= insertPos-1; i--)
                    {
                        data[i] = data[i - 1];
                    }
                    data[insertPos - 1] = newData;
                    count++;
                    break;
                case 0:
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Wrong option!");
                    break;
            }
        }
        while (option != 0);
    }
}
