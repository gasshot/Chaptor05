using System;


namespace p151_ex2_1
{
    class MainApp
    {
        

        static void Main(string[] args)
        {
            
            Console.Write("점수를 입력하세요 : ");
            string input = Console.ReadLine();
            int output = int.Parse(input);
            string grade;

            if (output >= 90)
                grade = "A";
            else if (output >= 80)
                grade = "B";
            else if (output >= 70)
                grade = "C";




        }
    }
}
