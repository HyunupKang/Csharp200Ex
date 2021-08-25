using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number66
{
    // 필드 : 클래스에서 선언되는 모든 형식의 변수를 멤버 변수 혹은 필드라고 함.
    //        보통 캡슐화를 위해 pirvate 또는 protected로 사용
    //        클래스에는 인스턴트 필드와 정적 필드의 두 종류가 있다

    // 인스턴스(객체) 필드 : 객체에 속한 필드로 객체의 이름과 함께 사용 [접근제한자][자료형][필드명}] ex ) public string name;
    //                       클래스의 인스턴스를 생성해야만 접근할 수 있는 필드
    //                       인스턴스를 생성할 때 마다 메모리에 매번 새로 생성되게 되는 반면,

    // 정적 필드           : 클래스 이름과 함께 쓰이는 필드를 클래스 필드 [클래스 이름][필드 명]
    //                       정적 필드는 클래스의 인스턴스를 만들지 않고도 클래스로부터 바로 접근이 가능
    //                       프로그램 실행 후 해당 클래스가 처음으로 사용될 때 한번 초기화되어 계속 동일한 메모리를 사용하게 된다.
    class Product
    {
        public string name;
        public int price;
    }

    class MyMath
    {
        public static double PI = 3.14;  // PI변수는 static double로 클래스 필드
    }

    class MyCalendar
    {
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / (double)weeks;
        public const double daysPerMonth = (double)days / (double)months;
    }

    class MemberVariables
    {
        static void Main(string[] args)
        {
            Product p = new Product(); // 클래스 Product 의 인스턴스 p를 생성하고, 각 필드에 값을 설정
            p.name = "시계";
            p.price = 10000;

            Console.WriteLine("{0} : {1:C}", p.name, p.price);
            Console.WriteLine("원주율 : {0}", MyMath.PI); // PI는 MyMath 클래스의 정적 필드이므로, 객체를 생성하지 않고 바로 사용
            Console.WriteLine("한 달은 평균 {0:F3}일", MyCalendar.daysPerMonth); // daysPerMonth는 MyCalendar의 정적 필드로, 객체 생성 안하고 바로 사용

        }
    }
} 