using System;
using System.Collections.Generic;



namespace p151_ex6
{
    class MainApp
    {

        static List<string> grades = new List<string>
        {"1","2","3","4"};


        static void Main(string[] args)
        {
            Console.WriteLine("중간고사 점수 합격 여부 프로그램.");
            Console.Write("현재 본인의 학년을 숫자만 입력하세요. (ex.2) : ");
            string grade = Console.ReadLine();
            Console.Write("현재 본인의 점수를 입력해 주세요. (ex.85) : ");
            string score = Console.ReadLine();

            string b;
            int g = int.Parse(grade);
            int c = int.Parse(score);

            if (!grades.Contains(grade))
            {
                Console.WriteLine("5,6학년은 사용하실 수 없습니다.");
                return;
            }


            if (c < 0 || c > 100)
            {
                Console.WriteLine("점수가 0미만 100초과했습니다!");
                return;
            }

            if (g == 4)
            {
                b = (c >= 70) ? "합격" : "불합격";
            }
            else
            {
                if (c >= 60)
                    b = "합격";
                else
                    b = "불합격";
            }

            Console.WriteLine("입력하신 점수는 {0}는(은) {1}입니다.", c, b);

        }
    }
}
