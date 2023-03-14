using System;


namespace p161_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("몇월이 궁금하세요 ? : ");
            string mouth = Console.ReadLine();
            int m = int.Parse(mouth);
            int d = 31;
            
            if (m < 1 || m > 12)
            {
                Console.WriteLine("다시 확인하세요");
                return;
            }


            switch (m)
            {
                case 2:
                    d = 28;
                    break;
                case 
                    d = 30;
                    break;
            }
        }
    }
}
