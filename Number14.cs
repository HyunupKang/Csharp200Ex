using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse() 와 TryParse()모두 문자열의 앞뒤에 있는 공백 무시
            // 문자열 중간에 공백이 있으면 에러
            // 문자열이 숫자를 나타내지 않는 경우 Parse는 에러 TryParse는 리턴함
            string input;
            int value;

            Console.Write("1. int로 변환할 문자열을 입력하세요 : ");
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value); //  input을 정수 value로 변환

            if(!result)
            {
                Console.WriteLine("'{0}'는 int로 변환할 수 없스니다.\n", input);
            }
            else
                Console.WriteLine("int '{0}'으로 변환됨.\n", value);

            Console.Write("2. double로 변환할 문자열을 입력");
            input = Console.ReadLine();
            try
            {
                double m = Double.Parse(input);
                Console.WriteLine("double '{0}'으로 변환되었습니다.\n", m);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}