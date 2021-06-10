using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A057_ArrayBasic
{
    class Program
    {
        //c#에서 배열은 참조형이므로 new 키워드를 사용하여 생성,
        //배열은 선언과 동시에 초기화 가능.
        //배열이나 리스트와 같이 데이터들을 모아 놓은 것을 컬렉션이라고 함
        //컬렉션은 foreach반복문을 사용하면 편리함
        //foreach(var value in a)는 a컬렉션의 각 요소값 value에 대해서  fksms EMt
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };      // 배열의 초기화
            Console.Write("a[]: ");
            foreach (var value in a)
                Console.Write(value + " ");

            int[] b = new int[] { 1, 2, 3 };
            Console.Write("\nb[]: ");
            for (int i = 0; i < 3; i++)
                Console.Write(b[i] + " ");

            int[] c = new int[3] { 1, 2, 3 };
            Console.Write("\nc[]: ");
            for (int i = 0; i < b.Length; i++)
                Console.Write(b[i] + " ");

            int[] d = new int[3];
            d[0] = 1;
            d[1] = d[0] + 1;
            d[2] = d[1] + 1;
            Console.Write("\nd[]: ");
            foreach (int value in d)
                Console.Write(value + " ");
            Console.WriteLine();
        }
    }
}
