using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contains() 메소드
            // 스트리엥 특정 문자열이 포함되어 있는지를 체크, 있으면 참 없으면 거짓 리턴하는 bool 메소드
            // 대소문자 구분
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "cow";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}", s2, s1, b);

            // IndexOf() 메소드
            // 문자열에서 특정 문자 또는 문자열이 나타내는 인덱스를 리턴. 이때 인덱스는 0 부터 시작.
            // 찾는 문자열이 없을 때는 -1을 리턴
            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at index {1}", s2, index);
            }

            // 대소문자 구분 안하려면, StringComparison 열거형 사용
            int i = s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase);
            if (i >= 0)
            {
                Console.WriteLine("'{0}' is in the string '{1}' ", s2, s1);
                Console.WriteLine("at index {0} (case insensitive)", i);
            }
        }
    }
}