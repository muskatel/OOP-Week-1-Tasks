namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int size = 7;
        char symbol = '%';

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (
                    (i == 0 || i == size - 1) || 
                    (j == 0 || j == size - 1))
                 {
                     Console.Write(symbol);
                 }
                 else
                 {
                     Console.Write(" ");
                 }
                // Console.Write($"({i},{j}) ");
            }
            Console.Write("\n");
        }
    }
}