//Anelyne 2-27-24

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 0 and 100:");
        double score;
        if (double.TryParse(Console.ReadLine(), out score))
        {
            if (score >= 99)
                Console.WriteLine("Grade Letter Equivalence: A+");
            else if (score >= 96)
                Console.WriteLine("Grade Letter Equivalence: A");
            else if (score >= 93)
                Console.WriteLine("Grade Letter Equivalence: A-");
            else if (score >= 90)
                Console.WriteLine("Grade Letter Equivalence: B+");
            else if (score >= 87)
                Console.WriteLine("Grade Letter Equivalence: B");
            else if (score >= 84)
                Console.WriteLine("Grade Letter Equivalence: B-");
            else if (score >= 81)
                Console.WriteLine("Grade Letter Equivalence: C+");
            else if (score >= 78)
                Console.WriteLine("Grade Letter Equivalence: C");
            else if (score >= 75)
                Console.WriteLine("Grade Letter Equivalence: C-");
            else if (score >= 72)
                Console.WriteLine("Grade Letter Equivalence: D+");
            else if (score >= 69)
                Console.WriteLine("Grade Letter Equivalence: D");
            else if (score >= 66)
                Console.WriteLine("Grade Letter Equivalence: D-");
            else if (score >= 63)
                Console.WriteLine("Grade Letter Equivalence: E+");
            else if (score >= 60)
                Console.WriteLine("Grade Letter Equivalence: F");
            else
                Console.WriteLine("Grade Letter Equivalence: F");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }
}