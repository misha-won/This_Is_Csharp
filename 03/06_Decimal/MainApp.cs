using System;

namespace _06_Decimal
// decimal 형식은 29자리 데이터를 표현할 수 있는 소수 형식으로, 16바이트(128비트)의 크기를 가진다.
// (회계 프로그램이나 계산기를 프로그래밍해야 한다면, decimal 형식이 가장 적합한 선택일 것이다.)
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            float   a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
            double  b = 3.1415_9265_3589_7932_3846_2643_3832_79;
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;

            Console.WriteLine(a);   // 3.1415927
            Console.WriteLine(b);   // 3.141592653589793
            Console.WriteLine(c);   // 3.1415926535897932384626433833
        }
    }
}
