using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string 객체 값은 불변임, 객체 값이 변경될 때마다 새로운 string을 만들어서 변수명에 할당해줘야함.
            // 빈번하게 변할 경우, 이는 실행 속도와 메모리 사용이 많아짐
            // C#은 StringBuilder 클래스를 제공함.
            // StringBuilder는 가변.
            // 문자열이 변경되면 자동으로 필요한 메모리를 동적으로 조정하고 내용을 바꿀 수 있음.

            // StringBuilder는 스트링을 추가, 제거, 수정하는 메소드를 제공
            // Capacity : 스트링빌더 객체에 할당된 메모리가 허용하는 최대 문자수를 가져오거나 설정
            // Length : 스트링빌터 객체의 길이를 가져오거나 설정
            StringBuilder sb = new StringBuilder("This is a StringBuilder Test.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Clear(); // 스트링빌터 객체의 모든 문자들을 없애줌
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Append("This is a new string."); // 객체의 끝에 문자열을 추가
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Insert(5, "xyz ", 2); // 특정한 위치에 지정한 문자열을 삽입 // sb의 5번째 위치에 "xyz"를 2번 삽입
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Remove(5, 4); // 특정 위치에 있는 문자열을 삭제 // sb 5번째 위치에서 4개의 문자를 삭제
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Replace("xyz", "abc"); // "xyz"를 "abc"로 대치
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            //for문 10만번 반복하면서 test에 숫자를 문자열로 추가. 시간 측정
            Stopwatch time = new Stopwatch();
            string test = string.Empty;
            time.Start();
            for (int i = 0; i < 100000; i++)
            {
                test += i;
            }
            time.Stop();
            Console.WriteLine("Using String concatenation: " + time.ElapsedMilliseconds + " milliseconds");

            // 스트링빌더 시간 측정
            StringBuilder test1 = new StringBuilder();
            time.Reset();
            time.Start();
            for (int i = 0; i < 100000; i++)
            {
                test1.Append(i);
            }
            time.Stop();
            Console.WriteLine("Using StringBuilder: " + time.ElapsedMilliseconds + " milliseconds");
        }
    }
}