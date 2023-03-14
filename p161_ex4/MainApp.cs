using System;

namespace p161_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("알고싶은 월을 입력해주세요. :");
            string input = Console.ReadLine();
            int m = Convert.ToInt32(input);
            string c = "겨울";

            if (m < 1 || m > 12)
            {
                Console.WriteLine("정상적인 입력값이 아닙니다. 다시 실행하여 주세요.");
                return;
            }

            switch (m)
            {
                case 3:
                case 4:
                case 5:
                    c = "봄";
                    break;
                case 6:
                case 7:
                case 8:
                    c = "여름";
                    break;
                case 9:
                case 10:
                case 11:
                    c = "가을";
                    break;
            }
            Console.WriteLine($"입력하신 {m}월은 {c}입니다.");
        }
    }
}
