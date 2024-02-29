using static System.Console;

// 3.9 문자열 다루기
// 3.9.1 문자열 안에서 찾기
// IndexOf() : 현재 문자열 내에서 찾으려고 하는 지정된 문자 또는 문자열의 위치를 찾는다
// LastIndexOf() : 현재 문자열 내에서 찾으려고 하는 지정된 문자 또는 문자열의 위치를 뒤에서부터 찾는다
// StartsWith() : 현재 문자열이 지정된 문자열로 시작하는지를 평가한다
// EndsWith() : 현재 문자열이 지정된 문자열로 끝나는지를 평가한다
// Contains() : 현재 문자열이 지정된 문자열을 포함하는지를 평가한다
// Replace() : 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환한다

namespace _25_StringSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // IndexOf()
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            // LastIndexOf()
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));

            // StartsWith()
            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            // EndsWith()
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            // Contains()
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            // Replace()
            WriteLine("Replaced 'Morning' with 'Evening' : {0}",
                greeting.Replace("Morning", "Evening"));

            // Good Morning

            // IndexOf 'Good' : 0
            // IndexOf 'o' : 1
            // LastIndexOf 'Good' : 0
            // LastIndexOf 'o' : 6
            // StartsWith 'Good' : True
            // StartsWith 'Morning' : False
            // EndsWith 'Good' : False
            // EndsWith 'Morning' : True
            // Contains 'Evening' : False
            // Contains 'Morning' : False
            // Replaced 'Morning' with 'Evening' : Good Evening
        }
    }
}
