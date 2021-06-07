using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A032_Enum
{
    class Program
    {
        // 열거형은 서로 관련 있는 상수들의 집함을 정의
        // 숫자에 특정한 명칭을 붙여주어 의미를 쉽게 이해할 수 있게 하는 용도로 사용
        // enum 문은 클래스 안이나 네임스페이스 내에서만 선언될 수 있다.
        // 즉, 메소드 안이나 프로퍼티 안에서는 선언 못함
        enum Size { Short, Tall, Grande, Venti }; // 열거형 Size를 정의.
        static int[] price = { 3300, 3800, 4300, 4800 }; // 정수 배열 price 정의.
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 }; // {}안의 숫자들은 기호 상수 값 설정함.
        enum Coffee { Short = 3300, Tall = 3800, Grande = 4300, Venti = 4800 };  // 사이즈를 기호 상수로 가격을 값으로 지정

        static void Main(string[] args)
        {
            Console.WriteLine("커피 가격표");

            // 열거형 Size의 각 요소에 대해 가격을 Price 배열에서 가져와서 출력.
            // Size.Short를 출력하려면 "Short"라는 문자열을 출력하고 이를 (int)로 캐스팅하면 기호 상수에 해당하는 숫자를 사용
            for (int i = 0; i < 4; i++)
            {
                if (i == (int)Size.Short)
                    Console.WriteLine("{0,10} : {1:C}", Size.Short, price[i]);
                else if (i == (int)Size.Tall)
                    Console.WriteLine("{0,10} : {1:C}", Size.Tall, price[i]);
                else if (i == (int)Size.Grande)
                    Console.WriteLine("{0,10} : {1:C}", Size.Grande, price[i]);
                else if (i == (int)Size.Venti)
                    Console.WriteLine("{0,10} : {1:C}", Size.Venti, price[i]);
            }

            Console.WriteLine("\n커피 가격표(Enum iteration)");
            foreach (var size in Enum.GetValues(typeof(Size))) // size는 Size의 Short, Tall 등을 차례로 지칭함.
            {
                Console.WriteLine("{0,10} : {1:C}", size, price[(int)size]); // (int)size는 size가 Short이면 0, Grande면 2
            }

            Console.WriteLine("\nColors Enum iteration");
            foreach (var color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine("{0,10} : {1}", color, Convert.ToInt32(color));
            }

            Console.WriteLine("\n커피 가격표(Enum iteration with value)");
            foreach (var coffee in Enum.GetValues(typeof(Coffee)))
            {
                Console.WriteLine("{0,10} : {1:C}", coffee, Convert.ToInt32(coffee));
            }
        }
    }
}
