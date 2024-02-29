using System;
using static System.Console;

// 3.9.3 문자열 분할하기
// Split() : 지정된 문자를 기준으로 현재 문자열을 분리한 다음 분리한 문자열의 배열을 반환한다
// SubString() : 현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자로 이루어진 새 문자열을 반환한다

namespace _27_StringSlice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning";
            
            WriteLine(greeting.Substring(0, 5));  // "Good"
            WriteLine(greeting.Substring(5));  // "morning"
            WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);

            // Good
            // morning
            // 
            // Word Count : 2
            // Good
            // morning
        }
    }
}
