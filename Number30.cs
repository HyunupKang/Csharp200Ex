using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 세자리 마다 콤마를 넣을 때, 콤마를 그룹 분리자 라고 함
            while (true)
            {
                Console.Write("표시할 숫자를 입력하세요(종료:-1): ");
                string s = Console.ReadLine();
                double v = double.Parse(s);
                if (v == -1)
                    break;
                Console.WriteLine(NumberWithGroupSeparator(s));
            }
        }
        // 소주점 아래 자릿수는 그대로 두고 정수부에만 세 자리씩 콤마 추가하는 코드
        private static string NumberWithGroupSeparator(string s)
        {
            int pos = 0;
            double v = Double.Parse(s);

            // s.Contain(",")메소드로 소수점이 있는지 검사. 있다면 문자열의 길이에서 소수점이 있는 인덱스를 뺀 값을 pos에 할당.
            // pos는 소수점 자릿수보다 1이 큰 수가 됨.(Length는 1부터 시작하니깐)
            // 그래서 pos-1이 소수점 아래 자릿수.
            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
                s = string.Format("{0:N0}", v);
            return s;
        }
    }
}