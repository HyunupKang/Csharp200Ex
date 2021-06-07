using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A034_ValueAndReference
{
    class Program
    { 
        // C# 자료형에는 두 가지 타입이 있다
        // 값 형식(value type)과 참조 형식(reference type)
        // 값 형식은 변수가 실제 데이터 값을 저장하는 형식
        // 참조 형식은 변수가 값이 저장되어 있는 위치를 저장, C의 포인터와 비슷한 개념
        
        // 값 형식 : int, double, char, bool 등, enum, struct
        // 참조 형식 : objcet, string, dynamic, class, inteface, delegate
        // 문자열이나 배열의 데이터는 힙 영역에 저장하고 스택에는 참조만 저장
        static void Main(string[] args)
        {
            string s = "before passing";
            Console.WriteLine(s);

            Test(s);
            Console.WriteLine(s);

            Test(ref s);
            Console.WriteLine(s);
        }

        public static void Test(string s)
        {
            s = "after passing";// 이 메소드 안에서 s가 변하지만, 이는 로컬변수 s의 내용이 바뀐것이므로 Main에서는 값이 변하지 않음
        }

        public static void Test(ref string s)
        {
            s = "after passing"; // ref 키워드에 의해 s의 값이 변하면 Main에서도 바뀜
        }
    }
}
