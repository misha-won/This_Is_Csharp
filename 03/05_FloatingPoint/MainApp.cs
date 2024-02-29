using System;

namespace _05_FloatingPoint
// float  : Floating Point, 단일 정밀도(Single Precision) 부동 소숫점 형식 (4바이트)
// double : Double Precision Floating Point, 복수 정밀도 부동 소숫점 형식 (8바이트)
// float 형식은 수를 표현할 때 1비트를 부호 전용으로 사용하고, 가수부 23비트를 수를 표현하는 데 사용한다.
// 그리고 나머지 지수부 8비트를 소숫점의 위치를 나타내기 위해 사용한다.
// float 형식은 유효숫자를 7자리밖에 가지지 않는다(7자리 이상의 수는 '대략적으로' 표현해야 한다).
// 한편, double 형식은 15~16개의 자릿수를 다룰 수 있다.
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            float a  = 3.1415_9265_3589_7932_3846f;
            Console.WriteLine(a);   // 3.1415927

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);   // 3.141592653589793
        }
    }
}
