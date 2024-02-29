using System;

namespace _10_Bool
// bool 형식 데이터의 크기는?
// 컴퓨터가 기본적으로 다루는 데이터의 크기가 바이트 단위이므로
// 1비트(TRUE = 1, FALSE = 0)만 저장하려 해도 한 바이트가 통째로 사용된다.
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
