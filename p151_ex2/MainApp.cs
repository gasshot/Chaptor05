using System;


namespace p151_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요 : ");
            string input = Console.ReadLine();
            int grade = int.Parse(input);

            if (grade >= 70)
            {
                if (grade >= 90)
                    Console.WriteLine($"입력하신 점수는 {grade}는(은) A 학점입니다.");
                
                else if (grade >= 80)
                    //{
                    Console.WriteLine($"입력하신 점수는 {grade}는(은) B 학점입니다.");
                    //}
                else
                    Console.WriteLine($"입력하신 점수는 {grade}는(은) C 학점입니다.");
            } 
            else 
            {
                Console.WriteLine($"입력하신 점수는 {grade}는(은) F 학점입니다.");
            }












            string sGrade;

            if (grade <= 69)
            { 
            
            }
            else if (grade >= 90)
            {
                sGrade = "A";
            }

            Console.WriteLine($"입력하신 점수는 {grade}는(은) "+sGrade+"학점입니다.");
        }
    }
}
