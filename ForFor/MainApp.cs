using System;


namespace ForFor
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 5; x++)
            {                
                for (int y = 0; y <= x; y++) 
                {
                    Console.Write("*");
                }

                Console.WriteLine(); 
            }
        }
    }
}