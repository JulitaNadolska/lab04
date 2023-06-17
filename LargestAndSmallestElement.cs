using System;

class Program
{
    static void Main()
    {
        int[] tableWithNumbers = new int[5];

        Console.WriteLine("Enter 5 digit: ");
        for (int i = 0; i < tableWithNumbers.Length; i++)
        {
            Console.Write("Digit {0}: ", i + 1);
            tableWithNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int smallest = tableWithNumbers[0];
        int biggest = tableWithNumbers[0];

        for (int i = 1; i < tableWithNumbers.Length; i++)
        {
            if (tableWithNumbers[i] < smallest)
            {
                smallest = tableWithNumbers[i];
            }

            if (tableWithNumbers[i] > biggest)
            {
                biggest = tableWithNumbers[i];
            }
        }
        Console.WriteLine("Smallest digit: " + smallest);
        Console.WriteLine("Biggest digit: " + biggest);
    }
}