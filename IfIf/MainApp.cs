using System;


namespace IfIf
{
    class MainApp
    {
        static void Main(string[] args)

        {
            Console.WriteLine("숫자를 입력하세요. : ");

            string input = Console.ReadLine();  //40 / 11 / 0

            int number = Convert.ToInt32(input);

            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"0보다 큰 짝수");  // 40  
                else
                    Console.WriteLine($"0보다 큰 홀수");  // 11
            }
            else
            {
                Console.WriteLine($"0보다 작거나 같은 수"); // 0
            }    
                
           
        }
    }
}
