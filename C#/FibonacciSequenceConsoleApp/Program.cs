// See https://aka.ms/new-console-template for more information

// This is my attempt at a Fibonacci sequence generator to the nth number

using System;
using System.Runtime.InteropServices;

namespace FibonacciSeq
{
class Program
{
    static void Main()
    {
        int CurrentNumber = 3;
        Console.WriteLine($"Setup {CurrentNumber}");

        // Let's think this through. The Fibonacci Sequence is the prior number + Current number = future number
        // 1 (1), 2 (1+1), 3 (2+1), 5 (3+2), 8 (5+3), 13 (8+5)

        //So, we need three variables. A previous number, a current number, and a future number. 
        //We need to loop through one process 'n' times

        Console.WriteLine("What is the nth number you want to reach? ");
        //int n = Console.Read(); 
        int n = int.Parse(Console.ReadLine());
        int loop = 0;
        int prior = 0;
        int current = 1;
        int next = 1;

        while (loop <= n)
        {
                
            loop = loop + 1;
            Console.WriteLine($"Number is {next}");   

            prior = current;
            current = next;
            next = current + prior;            
        }    
    }
}
}