using System;


namespace p151_ex5
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("세개의 정수 중 첫번째의 정수를 입력해 주세요. : ");
            string a = Console.ReadLine();
            Console.Write("세개의 정수 중 두번째의 정수를 입력해 주세요. : ");
            string b = Console.ReadLine();
            Console.Write("세개의 정수 중 세번째의 정수를 입력해 주세요. : ");
            string c = Console.ReadLine();
            int x = int.Parse(a);
            int y = int.Parse(b);
            int z = int.Parse(c);
            int min, max;

            max = x;

            if (y > z)
            {
                max = (max > y) ? max : y;
            }
            else
            {
                max = (max > z) ? max : z;
            }

            min = x;

            if (y < z)
            {
                min = (min < y) ? min : y;
            }
            else
            {
                min = (min < z) ? min : z;
            }


            Console.WriteLine($"입력하신 {x},{y},{z} 중 최대값은 {max}이며, 최소값은 {min}입니다.");
            Console.WriteLine($"입력하신 {x},{y},{z} 의 합은 {x+y+z}이며, 평균은 {(x+y+z)/3}입니다.");
        }
    }
}
