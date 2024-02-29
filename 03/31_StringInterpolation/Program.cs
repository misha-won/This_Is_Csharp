using System;
using static System.Console;

namespace _31_StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "유지민";
            int age = 23;
            WriteLine($"{name, -10}, {age:D3}");

            name = "김민정";
            age = 30;
            WriteLine($"{name}, {age, -10:D3}");

            name = "김애리";
            age = 17;
            WriteLine($"{name}, {(age > 19 ? "성인" : "미성년자")}");

            // 유지민       , 023
            // 김민정, 030
            // 김애리, 미성년자
        }
    }
}
