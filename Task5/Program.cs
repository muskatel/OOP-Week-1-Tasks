namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        for (int i = 0; i < 200; i++)
        {

            int card1 = rnd.Next(52); // creates a number between 0 and 51
            int card2 = rnd.Next(52); // creates a number between 0 and 51

            while (card1 == card2)
            {
                card2 = rnd.Next(52);
            }

            PrintCard(card1);
            PrintCard(card2);
            Console.WriteLine("---");
        }
    }

    static void PrintCard(int card)
    {
        //Console.WriteLine(card);
        switch (card % 13)
        {
            case 0:
                Console.Write(" A");
                break;
            case 1:
                Console.Write(" 2");
                break;
            case 2:
                Console.Write(" 3");
                break;
            case 3:
                Console.Write(" 4");
                break;
            case 4:
                Console.Write(" 5");
                break;
            case 5:
                Console.Write(" 6");
                break;
            case 6:
                Console.Write(" 7");
                break;
            case 7:
                Console.Write(" 8");
                break;
            case 8:
                Console.Write(" 9");
                break;
            case 9:
                Console.Write("10");
                break;
            case 10:
                Console.Write(" J");
                break;
            case 11:
                Console.Write(" Q");
                break;
            case 12:
                Console.Write(" K");
                break;
            
        }
        
        switch (card % 4)
        {
            case 0:
                Console.Write("♠️");
                Console.Write("S");
                break;
            case 1:
                Console.Write("♥️");
                Console.Write("H");
                break;
            case 2:
                Console.Write("♦️");
                Console.Write("D");
                break;
            case 3:
                Console.Write("♣️");
                Console.Write("C");
                break;
        }
        
        Console.Write("\n");
    }
}