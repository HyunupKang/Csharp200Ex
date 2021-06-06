using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // COnsole.ReadLine은 엔터를 입력할 때 까지 입력되는 한 줄을 하나의 스트링으로 저장

            Console.Write("더하고자 하는 숫자 입력 : ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split(); // 문자열을 빈칸으로 나누어 스트링 배열 v에 넣는다.
            foreach (var i in v)    // 배열에 저장된 갯수ㅏ 몇개인지 모르니 foreach문을 쓰는게 좋다.
            {
                sum += int.Parse(i);    // 배열의 각 요소 i를 정수로 변환하여 sum에 더함
            }
            Console.WriteLine("결과는 {0}", sum);
        }
    }
}