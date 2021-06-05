        //형식지정자
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("standerd Numeric format specifiers");

            Console.WriteLine(
                "(C) Currency:------{0:C}\n" +  //통화
                "(D) Decimal:-------{0:D}\n" +  //십진수
                "(E) Scientific:----{1:E}\n" +  //지수
                "(F) Fixed point:---{1:F}\n" +  //고정자릿수
                "(G) General:-------{0:G}\n" +  //일반
                "(N) Number:--------{0:N}\n" +  //천단위 구분 기호 숫자
                "(P) Percent:-------{1:P}\n" +  //퍼센트
                "(R) ROund-Trip:----{1:R}\n" +  //라운드트립
                "(X) Hexadecimal:---{0:X}\n" ,  //16진수
                -12345678, -12345678f);
        }