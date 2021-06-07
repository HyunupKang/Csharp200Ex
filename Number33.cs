using System;

namespace A033_ConstAndReadonly
{
    // const는 상수로 변하지 않는 값
    // const double meter = 1.09341;선언 후, meter값을 변경하려고 하면 에러 뜸
    // 선언될 때 값이 할당됨
    // 컴파일 시에 값이 결정됨
    // 클래스이름.변수이름 으로 사용

    // readonly
    // 읽기 전용
    // readonly 키워드를 붙인 변수는 변수를 선언하는 시점과 생성자 메소드에서만 값을 변경할 수 있다.
    // 생성될 때 또는 객체가 생성자에 의해 초기화될 때 값이 할당
    // 런타임 시에 값이 결정
    // 인스턴스이름.변수이름 으로 사용
    class ConstEx
    {
        public const int number = 3; // 이후에는 number의 값을 변경할 수 없다
    }

    class ReadonlyEx
    {
        public readonly int number = 10;
        public ReadonlyEx() // 생성자 1
        {
            number = 20;
        }
        public ReadonlyEx(int n) // 생성자 2
        {
            number = n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // const 사용
            Console.WriteLine(ConstEx.number);

            // readonly 사용
            ReadonlyEx inst1 = new ReadonlyEx();
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100);
            Console.WriteLine(inst2.number);
        }
    }
}
