namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // homework Q1
        Console.WriteLine("Please input a letter grade");
        string grade = Console.ReadLine();

        if (grade == "F")
        {
            Console.WriteLine("GPA point: 0");
        }
        else if (grade == "G")
        {
            Console.WriteLine("Wrong Letter Grade");
        }
    
           // homework Q2
        Console.WriteLine("Please input the first num:");
        int num1= Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second num:");
        int num2= Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third num:");
        int num3= Convert.ToInt16(Console.ReadLine());

        if (num1 <= num2)
        {
            if (num1 <= num3)
            {
                Console.WriteLine("The smallest value is:" + num1);
            }
            else
            {
                Console.WriteLine("The Smallest Value is:" + num3);
            }
        }
        else
        {
            if (num2 <= num3)
            {
                Console.WriteLine("The smallest value is:" + num2);
            }
            else
            {
                Console.WriteLine("The smallest value is:" + num3);
            }
        }
    }
}

