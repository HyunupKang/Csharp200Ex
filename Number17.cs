using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수/정수의 결과는 정수. 예) 1/2 = 0
            // 정수/실수의 결과는 실수.
            Console.WriteLine("정수의 계산");
            Console.WriteLine(123 + 45);
            Console.WriteLine(123 - 45);
            Console.WriteLine(123 * 45);
            Console.WriteLine(123 / 45);
            Console.WriteLine(123 % 45);

            Console.WriteLine("\n실수의 계산");
            Console.WriteLine(123.45 + 67.89);
            Console.WriteLine(123.45 - 67.89);
            Console.WriteLine(123.45 * 67.89);
            Console.WriteLine(123.45 / 67.89);
            Console.WriteLine(123.45 % 67.89);
        }
    }
}