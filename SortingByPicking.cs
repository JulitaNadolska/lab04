namespace lab04;

public class SortingByPicking
{
    static void Main()
    {
        int[] tableForSortingByPicking = new int[5];

        Console.WriteLine("Enter 5 digit: ");
        for (int i = 0; i < tableForSortingByPicking.Length; i++)
        {
            Console.Write("Digit {0}: ", i + 1);
            tableForSortingByPicking[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < tableForSortingByPicking.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < tableForSortingByPicking.Length; j++)
            {
                if (tableForSortingByPicking[j] < tableForSortingByPicking[minIndex])
                {
                    minIndex = j;
                }
            }
            (tableForSortingByPicking[minIndex], tableForSortingByPicking[i]) = (tableForSortingByPicking[i], tableForSortingByPicking[minIndex]);
        }
        Console.WriteLine("Sorted table by picking: ");
        for (int i = 0; i < tableForSortingByPicking.Length; i++)
        {
            Console.WriteLine(tableForSortingByPicking[i]);
        }
    }
}