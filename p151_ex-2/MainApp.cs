using System;


namespace p151_ex_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요 : ");
            string input = Console.ReadLine();
            int output = int.Parse(input);
            string a;

            if (output >= 50)
            a = "50이상";
            else
            a = "50미만";


            //Console.WriteLine(output >= 50 ? $"입력하신 숫자는 {output}는(은) 50이상의 숫자입니다." : $"입력하신 숫자는 {output}는(은) 50이상의 숫자입니다.");

           //Console.WriteLine(number, number >= 50 ? "" : "");


            Console.WriteLine($"입력하신 숫자는 {output}는(은) {a}의 숫자입니다.");
        }
    }
}
