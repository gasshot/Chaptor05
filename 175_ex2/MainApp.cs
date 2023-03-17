using System;

namespace p175_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {

            int i = 1;

            while (i>0)
            {
                Console.Write("중단하고 싶으시면 0을 눌러주세요. : ");
                string t = Console.ReadLine();
                int x = int.Parse(t);

                x = i;
            }
        }
    }
}
