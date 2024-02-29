using System;
using static System.Console;

// 3.9.4 문자열 서식 맞추기

// Format() 메서드
// : Console.WriteLine() 메서드가 이미 내부적으로 string.Format() 메서드를 사용한다.

// 서식 항목(Format Item) : 문자열 틀에 입력하는 {0}, {1}, ...
// {첨자, (좌우)맞춤: (변환 서식 지정)서식 문자열}
// ex. Console.WriteLine("Total : {0, -7, D}", 123); // 첨자 : 0, 맞춤 : -7, 서식 문자열 : D

namespace _28_StringFormatBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fmt = "{0, -20}{1, -15}{2, 30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");

            // Publisher           Author                                  Title
            // Marvel              Stan Lee                             Iron Man
            // Hanbit              Sanhyun Park                       This is C#
            // Prentice Hall       K&R                The C Programming Language
        }
    }
}
