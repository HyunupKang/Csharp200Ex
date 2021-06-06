using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string은 .NET의 System.String 클래스와 동일. int가 int32의 별명인것처럼
            // C# string은 불변. 한번 문자열이 설정되면 다시 변경할 수 없다. 예를들어 s="Hello"후 다시 s="World"라 하면, 
            // .NET시스템은 새로운 string 객체를 생성하여 World라는 데이터로 초기화한 후 이를 변수명 s에 할당.
            // 이전의 Hello를 저장하고 있던 메모리는 개비지 콜렉터에 의해 시스템에 반환

            // String 클래스의 속성인 Length는 String 객체의 길이. 또한 인덱스로 String의 특정 위치에 있는 문자를 가져올 수 있다
            // s.Length, s[8]과 같이 값을 가져올 수 있다. BUT 설정은 불가능

            // Empty와 null은 다르다.
            // Empty는 "" 즉, 빈 문자열
            // null은 선언되고 할당되지 않은 스트링을 의미

            // String클래스에는 다양한 메소드가 있다.
            // Insert : 특정 위치에 string삽입
            // Contains : 특정 문자 또는 문자열을 포함하는지 f/t로 리턴
            // CompareTo : string을 비교해서 작으면 - 같으면0 크면 + 값 리턴
            // IndexOf : string에서 특정 문자 또는 문자열이 처음으로 나오는 index를 리턴
            // LasIndexOf : string에서 특정 문자 또는 문자열이 마지막으로 나오는 idex를 리턴
            // PadLeft : string앞에 특정 문자를 삽입하여 글자 수를 맞춤
            // PadRight : string뒤에 특정 문자를 삽입하여 글자 수를 맞춤
            // Remove : string에서 substring을 삭제
            // Replace : string에서 문자 혹은 substring을 다른 문자 혹은 substring으로 대체
            // ToLower : string의 문자를 소문자로 변환
            // TOUpper : string의 문자를 대문자로 변환
            // Trim : string에서 앞뒤의 공백문자 또는 특정 문자를 제거
            // TrimEnd : string의 뒤의 공백문자 또는 특정 문자를 제거한다
            // TrimStart : string의 앞의 공백문자 혹은 특정 문자를 제거한다
            // Split : string에서 substing을 추출하여 새로운 string 배열을 리턴
            // CopyTO : string의 일부분을 문자 배열로 복사
            // Substring : string에서 특정 문자에서 끝까지 substring을 추출

            // 정적 메소드는 객체에 사용되는 멤버 메소드와 달리 클래스 자체에 적용되는 메소드
            // String 클래스의 정적 메소드들은 String.Format()과 같이 작성
            // Concat : 한개 이상의 substring을 합쳐서 새로운 string을 만든다
            // Compare : 두 개의 string을 비교해서 상대적인 위치를 리턴
            // Copy : 현재 string을 복사해서 새로운 string을 만든다
            // Format : 문자열을 포맷에 맞추어 변경
            // Join : 배열이나 컬랙션의 멤버들을 모아서 새로운 string을 만든다.이때 멤버 사이에 구분자 삽입
        }
    }
}