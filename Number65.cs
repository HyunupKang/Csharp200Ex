using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number65
{
    // 클래스는 참조형 : 할당된 메모리 영역에 실제 데이터(객체)에 대한 참조(메모리 주소) 저장 -> 그래서 반드시 new 키워드를 사용하여 만듦
    //                   스택에 참조만 위치하게 됨
    // 구조체는 값형 : 할당된 메모리 영역에 값을 직접 저장
    //                 메모리의 스택 영역에 공간을 갖게 됨

    struct DateStruct // 구조체는 주로 만든 후에 수정하지 않으려는 데이터를 포함하는 작은 데이터 구조에 적합함
    {
        public int year, month, day; // 멤버 변수를 필드라고 부름
    }
    class DateClass  // 복잡한 동작이나 객체를 만든 후 수정하려는 데이터를 모델링하는데 사용됨
    {
        public int year, month, day;
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateStruct sDay; // 구조체와 클래스로 만들어지는 변수를 인스턴스, 즉 객체라고 함
            sDay.year = 2018; // 객체의 필드는 멤버 연산자(.)을 사용하여 접근
            sDay.month = 11;
            sDay.day = 22;
            Console.WriteLine("sDay : {0}/{1}/{2}", sDay.year, sDay.month, sDay.day); // sDay: 2018 / 11 / 22

            DateClass cDay = new DateClass(); // new로 하면 객체의 필드값이 디폴드 값으로 초기화 ㅗ딤
            cDay.year = 2018;
            cDay.month = 11;
            cDay.day = 22;
            Console.WriteLine("sDay : {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);  // sDay: 2018 / 11 / 22

            DateStruct sDay2 = new DateStruct();
            Console.WriteLine("sDay2 : {0}/{1}/{2}", sDay2.year, sDay2.month, sDay2.day); // sDay2: 0 / 0 / 0

            DateClass cDay2 = new DateClass();
            Console.WriteLine("cDay2 : {0}/{1}/{2}", cDay2.year, cDay2.month, cDay2.day); // cDay2: 0 / 0 / 0

            DateStruct s = sDay;
            DateClass c = cDay;

            s.year = 2000;
            c.year = 2000;

            Console.WriteLine("s : {0}/{1}/{2}", s.year, s.month, s.day); // s: 2000 / 11 / 22
            Console.WriteLine("c : {0}/{1}/{2}", c.year, c.month, c.day); // c: 2000 / 11 / 22
            Console.WriteLine("sDay : {0}/{1}/{2}", sDay.year, sDay.month, sDay.day); // sDay: 2018 / 11 / 22
            Console.WriteLine("cDay : {0}/{1}/{2}", cDay.year, cDay.month, cDay.day); // cDay: 2000 / 11 / 22
        }
    }
}