namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        string[] name = ["Craig", "Steve", "Miranda", "Suzy", "Rosie"];
        string[] telephone = ["42", "11", "1606", "1234","7890"];

        
        for (int num = 0; num < name.Length; num++)
        {
            Console.WriteLine($"{name[num]} - {telephone[num]}");
        }
        
    }
}