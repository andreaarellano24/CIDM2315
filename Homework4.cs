namespace Homework4;

class Program
{
    //Call Q1_method()
    static int Largest(int a, int b)
    {
        if (a>b)
            return a;
        else 
            return b;
    }

    //Call Q2_method
    static void PrintTraining(int N, string shape)
    {
        Console.WriteLine("N is: " + N + ", shape is: " + shape);
        
        if (shape == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (shape == "right")
        {
            for (int i = 1; i<= N ; i++)
            {
                for (int space = 1; space <= N - i; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 1; star <= i; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }

    static void Main()
    {
        //Call Q1 method 
        int a = 3;
        int b = 5;
        int result = Largest(a, b);
        Console.WriteLine("a = " + a + " , b = " + b);
        Console.WriteLine("The largest number is: " + result);


        // Call Q2 method
        PrintTraining(5, "left");
        Console.WriteLine();
        PrintTraining(5, "right");
    }
}

