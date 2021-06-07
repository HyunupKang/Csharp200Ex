using System;

namespace A039_Object
{
    class Program
    {
        // 모든 형식은 Object로부터 상속됨.
        // Object 타입은 모든 데이터의 조상이고 object 타입의 변수에는 어떠한 값이라도 할당할 수 있다.
        // 박싱(Boxing) 값 형식의 변수가 object타입으로 변환
        // 언박싱(unboxing) : object 타입의 변수가 값 형식으로 변환되는 것

        // object 타입은 참조형식이기 때문에 힙에 데이터를 할당.
        // int 같은 값형식의 자료는 스택에 데이터를 할당,
        
        // 언박싱은 object에서 값 형식을 꺼내는것. 그래서 언박싱은 (int)와 같이 형식변환을 위한 캐스팅 필요
        static void Main(string[] args)
        {
            int i = 123;

            object o = i; // i의 값을 박싱하여 o로 복사합니다

            i = i + 10; // i의 값을 바꿉니다. o는 변하지 않습니다.

            int j = (int)o; // o의 값을 언박싱하여 j로 복사합니다.

            // i의 값이 변해도 o에 저장된 값은 영향받지 않습니다.
            Console.WriteLine("The value-type value i = {0}", i);
            Console.WriteLine("The object-type value o = {0}", o);
            Console.WriteLine("The value-type value j = {0}", j);

            object p = o;
            o = 100;
            Console.WriteLine("The object-type value o = {0}", o);
            Console.WriteLine("The object-type value p = {0}", p);
        }
    }
}
