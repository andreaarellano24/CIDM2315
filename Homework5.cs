namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        Q1_method();
        Q2_method();
        Q3_method();
    }

    // Q1
    static void Q1_method()
    {
        Console.WriteLine("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int largest = LargestOfTwo(num1, num2);

        Console.WriteLine("The largest number is:" + largest);
    }

    static int LargestOfTwo(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    //Q2
    static void Q2_method()
    {
        int a = 3, b = 5, c = 7, d =9;

        int max1 = LargestOfTwo(a, b);
        int max2 = LargestOfTwo(c, d);
        int max = LargestOfTwo(max1, max2);

        Console.WriteLine("The largest number is: " + max);
    }

    //Q3
    static void Q3_method()
    {
        createAccount();
    }

    static bool checkAge(int birth_year)
    { 
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;

        return age >= 18;
    }

    static void createAccount()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine()!;

        Console.Write("Enter your password: ");
        string password1 = Console.ReadLine()!;

        Console.Write("Enter your password again: ");
        string password2 = Console.ReadLine()!;

        Console.Write("Enter your birthyear: ");
        int birthYear= Convert.ToInt32(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password1 == password2)
                Console.WriteLine("Account is created successfully");
            else 
                Console.WriteLine("Wrong password");
        }
        else
        {
            Console.WriteLine("Could not create and account");
        }
    }
}
        