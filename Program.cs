﻿using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient;
            int remainder;

            Console.WriteLine($"Addition result is {a + b}");
            Console.WriteLine($"Subtraction result is {a - b}");
            Console.WriteLine($"Multiplication result is {a * b}");
            quotient = a / b;
            remainder = a % b;
            if ((a == 17) && (b == 4))
               Console.WriteLine($"{a}/{b} is {a / b}  remainder {a % b}");

            
        }
    }
}
