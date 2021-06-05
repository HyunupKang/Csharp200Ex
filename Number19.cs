using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 오버플로 메세지를 표시하기 위해서는 checked 키워드를 사용, checked키워드는 오버플로 예외를 발생시킴 

            int x = int.MaxValue, y = 0;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    }
}