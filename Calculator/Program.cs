using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Please fill in first number");
            int firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please fill in operation");
            char operation = char.Parse(Console.ReadLine());


            Console.WriteLine("Please fill in second number");
            int secondnumber = int.Parse(Console.ReadLine());


            Calculations a = new Calculations(firstnumber, secondnumber);

         
            switch (operation)
            {

                case '+':
                    int sum = a.Plus(firstnumber, secondnumber);
                    Console.WriteLine(sum);
                    break;

                case '-':
                    int min = a.Minus(firstnumber, secondnumber);
                    Console.WriteLine($"Answer is {min}");
                    break;

                case '*':
                    int umn = a.Umnozhit(firstnumber, secondnumber);
                    Console.WriteLine($"Answer is {umn}");
                    break;

                case '/':
                    int del = a.Delit(firstnumber, secondnumber);
                    Console.WriteLine($"Answer is {del}");
                    break;

                


            }

            



        }
    }
}
