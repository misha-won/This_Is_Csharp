// using ~ : 네임스페이스 전체를 사용한다는 의미의 키워드
// using static ~ : 어떤 데이터 형식(예 - 클래스)의 정적 멤버를 데이터 형식의 이름을 명시하지 않고 참조하겠다고 선언하는 기능을 함
using System;
using static System.Console;

// 네임스페이스 : 성격이나 하는 일이 비슷한 클래스, 구조체, 인터페이스, 대리자, 열거 형식 등을 하나의 이름 아래 묶는 일을 함
// .NET 클래스 라이브러리에 1만 개가 훨씬 넘는 클래스가 있어도 프로그래머가 전혀 혼돈을 느끼지 않고 이 클래스들을 사용할 수 있는 비결
// namespace 네임스페이스_이름
// {
//     클래스
//     구조체
//     인터페이스 ...
// }
namespace _01_Hello
{
    // 클래스 : C# 프로그램을 구성하는 기본 단위
    // 데이터와 데이터를 처리하는 기능(메소드)으로 이루어짐
    internal class MainApp
    {
        // 메소드 Main : 프로그램의 진입점(Entry Point)으로서 프로그램을 시작하면 실행되고, 이 메소드가 종료되면 프로그램도 종료됨
        // ***따라서 모든 프로그램은 반드시 메소드 Main을 하나 가지고 있어야 함***
        // 메소드 코드를 이루는 키워드 :
        // [한정자(modifier)] [반환 형식] [메소드 이름] ( [매개변수] ) { [코드 블록] }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            }

            WriteLine("Hello, {0}!", args[0]);  // 프롬프트에 출력
        }
    }
}