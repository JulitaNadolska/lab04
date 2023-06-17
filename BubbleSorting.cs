namespace lab04;

public class BubbleSorting
{
    static void Main()
    {
        int[] tableForBubbleSorting = new int[5];

        Console.WriteLine("Enter 5 digit: ");
        for (int i = 0; i < tableForBubbleSorting.Length; i++)
        {
            Console.Write("Digit5" +
                          " {0}: ", i + 1);
            tableForBubbleSorting[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < tableForBubbleSorting.Length - 1; i++)
        {
            for (int j = 0; j < tableForBubbleSorting.Length - 1 - i; j++)
            {
                if (tableForBubbleSorting[j] > tableForBubbleSorting[j + 1])
                {
                    (tableForBubbleSorting[j], tableForBubbleSorting[j + 1]) = (tableForBubbleSorting[j + 1], tableForBubbleSorting[j]);
                }
            }
        }
        Console.WriteLine("Table sorted by Bubble Sorting: ");
        for (int i = 0; i < tableForBubbleSorting.Length; i++)
        {
            Console.WriteLine(tableForBubbleSorting[i]);
        }
    }
}