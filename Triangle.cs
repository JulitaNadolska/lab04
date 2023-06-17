namespace lab05;

public class Triangle
{
    static void Main()
    {
        Console.Write("Enter the height of the triangle:");
        int height = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < height; i++)
        {
            int numberOfCharacters = i * 2 + 1;
            int numberOfSpaces = height - i - 1;

            for (int j = 0; j < numberOfSpaces; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < numberOfCharacters; j++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
        }
    }
}