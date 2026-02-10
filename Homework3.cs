namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1
        Console.WriteLine("Input an integer:");
        int n = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;
        int i = 2;
        while (isPrime && i < n)
        {
            if (n % i == 0)
                isPrime = false;
            i++;
        }
        if (isPrime) Console.WriteLine("N is prime");
        else Console.WriteLine("N is non-prime");
    
        //Code for Q2
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt32(Console.ReadLine());
        for  (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        //Code for Q3
        Console.WriteLine("Assign an int value to N:");
        int N2 = Convert.ToInt32(Console.ReadLine());

        for (int row = 1; row <= N2; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
