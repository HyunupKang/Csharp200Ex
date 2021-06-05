        static void Main(string[] args)
        {
            float flt = 1F / 3;     //4byte
            double dbl = 1D / 3;    //8byte
            decimal dcm = 1M / 3;   //16byte

            Console.WriteLine("float : {0}\ndouble : {1}\ndecimal : {2}", flt, dbl, dcm);

            Console.WriteLine("float : {0}~{1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double : {0}~{1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal : {0}~{1}", decimal.MinValue, decimal.MaxValue);
        }