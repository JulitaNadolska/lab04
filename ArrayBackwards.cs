namespace lab04;

public class ArrayBackwards
{
    static void Main()
    {
        int[] newTableWithRandomNumbers = new int[5];
        Random random = new Random();
        for (int i = 0; i < newTableWithRandomNumbers.Length; i++)
        {
            newTableWithRandomNumbers[i] = random.Next(1, 100); 
        }
        for (int i = newTableWithRandomNumbers.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(newTableWithRandomNumbers[i]);
        }
    }
}