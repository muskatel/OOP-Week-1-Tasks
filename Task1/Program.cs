namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        // Write a program to calculate the first 20 Fibonacci numbers in sequence.
        // Print each number as it is calculated.
        
        //  
        // 0 1 2 3 4 5 6 7  8  9 

        UInt128 fc = 1;
        UInt128 fn = 1;
        
        
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine($"Fib({i+1}) = {fc}");
            UInt128 temp = fn;
            fn = fn + fc; //alternative: fn += fc;
            fc = temp;
            if (fn >= UInt128.MaxValue - fc)
                break;
        }

        float test = 3.11E+4f;


    }
}