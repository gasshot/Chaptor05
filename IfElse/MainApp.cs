using System;

namespace IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            //int number = int.Parse(input);

            if (number < 0)
            {
                Console.WriteLine("음수");
            }
            else if (number > 0)
            {
                Console.WriteLine("양수");
            }
            else
            {
                Console.WriteLine("0");
            }

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("짝수");
            //}
            //else
            //{
            //    Console.WriteLine("홀수");
            //}

            string test;
            test = number % 2 == 0 ? "짝수":"홀수";

            Console.WriteLine(test);


        }
    }
}
