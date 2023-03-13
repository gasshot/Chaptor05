using System;


namespace p151_ex2_1
{
    class MainApp
    {
        

        static void Main(string[] args)
        {

            Console.Write("점수를 입력하세요 : ");

            string input = Console.ReadLine();
            string grade = "A";

            if (input != "100")
            {
                input = input.Substring(0, 1);

                grade = (input == "9") ? "A" : "B";
                if (input != "8")
                    grade = (input == "7") ? "C" : "F";
            }
            

            Console.WriteLine($"입력하신 점수는 {input}는(은) {grade} 학점입니다.");
        }
    }
}
