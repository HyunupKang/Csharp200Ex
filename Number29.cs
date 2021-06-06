using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 지정된 형식에 따라 객체, 변수, 수식의 값을 문자열로 변환하여 다른 문자열에 삽입

            // Int64의 최대값을 각각 16진수, 지수형, 구분자(,)가 있는 숫자형으로 변환하여 max에 할당하고 출력     
            string max = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            Console.WriteLine(max);

            Decimal exchangeRate = 1129.20m;

            string s = String.Format("현재 원달러 환율은 {0}입니다.", exchangeRate);
            Console.WriteLine(s);

            s = String.Format("현재 원달러 환율은 {0:C2}입니다.", exchangeRate); // C는 통화 형식, 원 기호와 3자리마다 콤마 넣어줌
            Console.WriteLine(s);

            s = String.Format("오늘 날짜는 {0:d}, 시간은 {0:t} 입니다.", DateTime.Now);
            Console.WriteLine(s);

            TimeSpan duration = new TimeSpan(1, 12, 23, 62);  // Timespan 구조체
            string output = String.Format("소요 시간: {0:c}", duration);
            Console.WriteLine(output);
        }
    }
}