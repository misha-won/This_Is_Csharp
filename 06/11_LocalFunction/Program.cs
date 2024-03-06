// 6.11 로컬 함수(Local Function)
// - 메서드 안에서 선언되고, 선언된 메서드 안에서만 사용되는 특별한 함수이다.
// - 클래스의 멤버가 아니므로 메서드가 아니라 함수라고 부른다.
// - 선언 방법은 메서드와 동일하다.
// - 자신이 존재하는 지역에 선언되어 있는 변수를 사용할 수 있다.
// - 메서드 밖에서는 다시 쓸 일 없는 반복적인 작업을 하나의 이름 아래 묶어 놓는 데 제격이다.

namespace _11_LocalFunction
{
    internal class Program
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i) // 로컬 함수 선언
            {
                // ToLowerString() 메서드의 지역변수 arr 사용
                if (arr[i] < 65 || arr[i] > 90) // A ~ Z의 ASCII 값 : 65 ~ 90
                    return arr[i];
                else                            // a ~ z의 ASCII 값 : 97 ~ 122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToLowerString("This is C#."));

            // hello!
            // good morning.
            // this is c#.
        }
    }
}
