using System;

namespace SyntaxSugar3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int answer = 4;
            //string response;

            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + "greater than or equal to nine";
            //}

            //var answer = 4;
            //var response = (answer < 9) ? $"{answer} is less than nine." : $"{answer} is greater than nine";

            //Console.WriteLine(response);

            Console.WriteLine("How old are you?");
            var age = int.Parse(Console.ReadLine());
            var response = (age >= 21) ? $"{age} is old enough to drink." : $"{age} is not old enough to drink.";

            Console.WriteLine(response);

            //just for comments

        }
    }
}
