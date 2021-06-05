using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2147483647; // int -> lont은 데이터 손실이 안일어남, 그래서 캐스트(cast) 필요 없음
            long bitnum = num;
            Console.WriteLine(bitnum);

            double x = 1234.5;   // 소수는 자동으로 double임. 그래서 float f = 1234.5;를 하면 에러, 1234.5f를 해야됨
            int a;

            a = (int)x;         // double -> int는 소수점에 데이터 손실이 일어나서 캐스트 해야 함
            Console.WriteLine(a);
        }
    }
}