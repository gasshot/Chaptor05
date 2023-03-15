using System;


namespace p161_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("몇월이 궁금하세요 ? : ");
            string mouth = Console.ReadLine();
            //int m = int.Parse(mouth);
            bool chk = int.TryParse(mouth, out int m);
            int d = 31;

            if (m < 1 || m > 12 || !chk)
            {
                Console.WriteLine("정상적인 입력값이 아닙니다. 다시 실행하여 주세요.");
                return;
            }


            switch (m)
            {
                case 2:
                    d = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    d = 30;
                    break;
            }

            Console.WriteLine($"{m}월은 {d}일까지 있습니다.");
        }
    }
}
