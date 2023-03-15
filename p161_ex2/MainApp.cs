using System;


namespace p161_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개와 연산기호를 입력해주세요!");
            Console.Write("첫번째 정수를 입력해주세요. : ");
            string f = Console.ReadLine();
            //int x = int.Parse(f);
            Console.Write("두번째 정수를 입력해주세요. : ");
            string s = Console.ReadLine();
            //int y = int.Parse(s);
            Console.Write("연산기호를 입력해주세요. ex) +,-,*,/,% :");
            string i = Console.ReadLine();
            int p = 0;

            bool chks1 = int.TryParse(f, out int x);
            bool chks2 = int.TryParse(s, out int y);


            if (!chks1 || !chks2)
            {
                Console.WriteLine("정수만 입력하십시요.");
                return;
            }

            switch (i)
            {
                case "+":
                    p = x + y;
                    break;
                case "-":
                    p = x - y;
                    break;
                case "*":
                    p = x * y;
                    break;
                case "/":
                    p = x / y;
                    break;
                case "%":
                    p = x % y;
                    break;
                default:
                    Console.WriteLine("+,-,*,/,% 에 해당하는 값을 입력해주시길 바랍니다.");
                    return;
            }

            Console.WriteLine($"입력하신 {f} {i} {s}의 결과값은 {p}입니다.");

        }
    }
}
