using System;

namespace For
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)  // int i는 for영역에서만 사용됨 조건의 대해 FALSE면 for문 종료
            {
                Console.WriteLine(i);
            }
        }
    }
}





