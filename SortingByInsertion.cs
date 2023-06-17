namespace lab04;

public class SortingByInsertion
{
    static void Main()
    {
        int[] tableForSortingByInsertion = new int[5];

        Console.WriteLine("Enter 5 digit: ");
        for (int i = 0; i < tableForSortingByInsertion.Length; i++)
        {
            Console.Write("Cyfra {0}: ", i + 1);
            tableForSortingByInsertion[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 1; i < tableForSortingByInsertion.Length; i++)
        {
            int aktualDigit = tableForSortingByInsertion[i];
            int j = i - 1;

            while (j >= 0 && tableForSortingByInsertion[j] > aktualDigit)
            {
                tableForSortingByInsertion[j + 1] = tableForSortingByInsertion[j];
                j--;
            }
            tableForSortingByInsertion[j + 1] = aktualDigit;
        }
        Console.WriteLine("Sorted table by insertion: ");
        for (int i = 0; i < tableForSortingByInsertion.Length; i++)
        {
            Console.WriteLine(tableForSortingByInsertion[i]);
        }
    }
}