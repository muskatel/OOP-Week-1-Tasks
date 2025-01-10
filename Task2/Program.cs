namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int size = 5;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("#");
                //Console.Write($"({i},{j}) ");
            }
            Console.Write("\n");
        }
    }
}