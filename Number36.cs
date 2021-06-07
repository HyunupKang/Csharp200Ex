using System;

namespace A036_NullCOnditionalOperator
{
    class Program
    {
        // C#에서 null이란 "어떤 객체도 참조하지 않는 참조형 변수"라는 뜻, null은 참조형 변수의 디폴트 값
        static void Main(string[] args)
        {
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");
            do
            {
                LongNameAnimal(animal);
                Console.Write("동물이름: ");
            } while ((animal = Console.ReadLine()) != "");
        }

        private static void LongNameAnimal(string animal)
        {
            //if (animal.Length >= 4) ? 연산자가 없으면 예외처리됨, do로 인해 동물 이름 입력 받기도 전에 LongNameAnimal실행되며 예외로 빠짐
            if (animal?.Length >= 4) // animal이 null일 떄는 Lehgth를 찾지 않음
                Console.WriteLine(animal + " : " + animal.Length);
        }
    }
}
