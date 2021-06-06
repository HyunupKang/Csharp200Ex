using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // +연산자 사용
            string username = "steve";
            string dataString = "aug 1, 2019";
            string str = "Hello " + username + ". Today is " + dataString;
            str += ".";
            Console.WriteLine(str);

            // 문자열 보간 : $문자 사용
            string username2 = "bikang";
            string data = DateTime.Today.ToShortDateString();
            string str2 = $"Hello {username2}. TOday i s{data}.";            
            Console.WriteLine(str2);

            // String.Format
            decimal temp = 20.4m;
            string s = String.Format("At {0}, the temperature is {1} C", DateTime.Now, temp);
            Console.WriteLine(s);

            // Concat
            Console.WriteLine(String.Concat("I", "am", "a", "boy")); // 문자열을 따라락 붙여버림

            // Join
            string[] animal = { "moutse", "cow", "tiger" };
            string s2 = string.Concat(animal);
            Console.WriteLine(s2);
            s2 = string.Join(", ", animal); // 문자열 사이에 ,를 넣으면서 붙임
            Console.WriteLine(s2);
        }
    }
}