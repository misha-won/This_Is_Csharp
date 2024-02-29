using System;

namespace _08_String
// string 형식은 정해진 크기나 담을 수 있는 데이터의 범위가 따로 정해져 있지 않다.
// 변수가 담는 텍스트의 양에 따라 그 크기가 달라지기 때문이다.
// (string 형식은 그 자체로 클래스이다?)
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string a = "안녕하세요?";
            string b = "원성민입니다.";

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
