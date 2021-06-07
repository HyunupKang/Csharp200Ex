using System;

namespace A038_Nullable
{
    class Program
    {
        // 값 형식에 null 값을 할당할 수 없다.
        // Nullable형은 언제 필요할 까? 
        // Null이란 "값이 없다", "정해지지 않았다"라는 의미
        // 따라서 Nullalble은 데이터베이스에서 자주 사용
        // 예를  들어 데이터베이스에서 나이를 가져와서 int age에 할당하려고 할떄, 그 컬럼의 값이 null이라면 int에 가져올 수 없당
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            Console.WriteLine("i=" + i);
            Console.WriteLine(i.GetValueOrDefault());

            if (i.HasValue)
                Console.WriteLine(i.Value); // or Console.WriteLine(i)
            else
                Console.WriteLine("Null");

            int? x = null;
            int j = x ?? 0;
            Console.WriteLine("x = {0}, j = {1}", x, j);

            Console.WriteLine("x >= 10 ? {0}", x >= 10);
            Console.WriteLine("x < 10 ? {0}", x < 10);

            if (Nullable.Compare<int>(i, j) < 0)
                Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");
        }
    }
}
