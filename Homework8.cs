using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);

        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        TotalCredits(customer_list);
        AmarilloAverageAge (customer_list);
        CanyonAge(customer_list);

    }

    public static void TotalCredits(Customer[ ]customer_list)
    {
        double total = 0;
        foreach (Customer c in customer_list)
        {
            total += c.customerCredit;
        }
        Console.WriteLine("Q1: The total credits:" + total);
    }

    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        int totaleAge = 0;
        int count = 0;

        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Amarillo")
            {
                totaleAge += c.customerAge;
                count++;
            }
        }
        double avg = (double)totaleAge / count;

        Console.WriteLine("Q2: The average age of customers in Amarillo: " + avg);
    }

    public static void CanyonAge(Customer[] customer_list)
    {
        Console.WriteLine("Q3: Customers who live in Canyon and over 30 years old: ");
        foreach (Customer c in customer_list)
        {
            if(c.customerCity == "Canyon" && c.customerAge > 30)
            {
                Console.Write(c.customerName + ", ");
            }
        }
        Console.WriteLine();
    }
}

class Customer
    {
        public string customerName;
        public int customerAge;
        public string customerCity;
        public double customerCredit;

        public Customer(string name, int age, string city, double credit)
        {
            customerName = name;
            customerAge = age;
            customerCity = city;
            customerCredit = credit; 
        }
    }

