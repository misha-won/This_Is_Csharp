using System;

// C#은 변수나 상수에 대해 엄격하게 형식 검사를 하는 강력한 형식의 언어(Strong Typed Language)
// -> 의도치 않은 형식의 데이터를 읽거나 할당하는 일을 막아 준다.

// var 키워드
// - 약한 형식 검사를 하는 언어의 편리함을 갖췄다.
// - var 키워드를 사용하면 컴파일러가 자동으로 변수의 형식을 지정해 준다.
// - 지역 변수로만 사용할 수 있다.

// * 클래스의 필드를 선언할 때는 반드시 명시적 형식을 선언해야 한다.
// (선언과 같이 초기화하지 않는 경우가 많기 때문)

// 지역 변수(Local Variable)
// - 코드 블록 안에서 선언되는 변수
// - 코드 블록에서만 사용되고 코드 블록이 종료될 때 소멸된다.
// - 프로그램의 다른 코드에서는 접근할 수 없다.

// 전역 변수(Global Variable)
// - 프로그램의 어느 코드에서나 접근해서 사용할 수 있다.
// - 코드의 가독성을 해치고 오류를 낳는 문제 때문에 C#에서는 지원하지 않는다.

namespace _23_UsingVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);
            // Type: System.Int32, Value: 20

            var b = 3.1414213;
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);
            // Type: System.Double, Value: 3.1414213

            var c = "Hello, World!";
            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);
            // Type: System.String, Value: Hello, World!

            var d = new int[] { 10, 20, 30 };
            Console.WriteLine("Type: {0}, Value: ", d.GetType());
            foreach (var e in d)
                Console.Write("{0} ", e);
            Console.WriteLine();
            // Type: System.Int32[], Value: 10 20 30
        }
    }
}

// var 형식과 object 형식의 차이? (object a = 20; vs. var a = 20;)
// object 형식은 그 자체로 object 형식일 뿐이다. object a = 20;을 컴파일하면,
// CLR은 20을 박싱해서 힙에 넣어 놓고 a가 힙을 가리키도록 만든다.
// var a = 20;은 컴파일 시점에서 컴파일러가 a에 적합한 데이터 형식을 파악해서
// int a = 20;으로 바꾸어 컴파일한다.