using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number68
{
    // 객체가 만들어지면서 수행해야 하는 작업을 생성자라고 하는 특별한 메소드를 코딩
    // 생성자는 객체가 생성될 때 처리되는 메소드
    // 리턴값이 없으면 중복해서 정의할 수 있다.
    class Date
    {
        private int year, month, day;  // 캡슐화를 위해 private
        
        public Date() // 매개 변수가 없는 생성자, 필드를 모두 1로 설정
        {
            year = 1;
            month = 1;
            day = 1;
        }

        public Date(int y, int m, int d) // 매개변수가 있는 생성자
        {
            year = y;
            month = m;
            day = d;
        }

        public void PrintDate() // 인스턴스 메소드. 객체의 연월일 값 출력
        {
            Console.WriteLine("{0}/{1}/{2}", year, month, day);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date(2000, 11, 22); // 매개변수 있는 생성자에 의해 필드 초기화
            Date christmas = new Date(2018, 12, 25);
            Date firstDate = new Date();

            birthday.PrintDate(); // 2000/11/22
            christmas.PrintDate(); // 2018/12/25
            firstDate.PrintDate(); // 1/1/1
        }
    }
}