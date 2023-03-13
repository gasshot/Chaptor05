using System;


namespace p151_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("정수 1개를 입력하세요 : ");
            string input = Console.ReadLine();

           

            int output = int.Parse(input);
            string a = "3의 배수가 아닙"; ;




            if (output % 3 == 0)
            {
                a = "3의 배수입";
            }


            Console.WriteLine($"입력하신 정수 {output}은(는)" + $"{a}니다.");
            //Console.WriteLine(output % 3 == 0 ? $"입력하신 정수 {output}은(는) 3의 배수입니다." : $"입력하신 정수 {output}은(는) 3의 배수가 아닙니다."); 
        }
    }
}
